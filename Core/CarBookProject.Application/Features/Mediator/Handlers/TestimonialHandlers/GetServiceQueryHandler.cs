﻿using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using CarBookProject.Application.Features.Mediator.Results.TestimonialResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetServiceQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Name = x.Name,
                TestimonialID = x.TestimonialID,
                ImageUrl = x.ImageUrl,
                Title = x.Title,
                Comment = x.Comment
            }).ToList();
        }
    }
}