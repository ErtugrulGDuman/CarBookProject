﻿using CarBookProject.Application.Features.Mediator.Queries.RentACarQueries;
using CarBookProject.Application.Features.Mediator.Results.RentACarResults;
using CarBookProject.Application.Interfaces.RentACarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
            var results = values.Select(y => new GetRentACarQueryResult
            {
                CarId = y.CarID,
                Brand = y.Car.Brand.BrandName,
                Model = y.Car.Model,
                CoverImageUrl = y.Car.CoverImageUrl
            }).ToList();
            return results;
        }
    }
}
