﻿using CarBookProject.Application.Features.Mediator.Queries.AuthorQueries;
using CarBookProject.Application.Features.Mediator.Results.AuthorResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        public GetServiceQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Name = x.Name,
                AuthorID = x.AuthorID,
                ImageUrl = x.ImageUrl,
                Description = x.Description
            }).ToList();
        }
    }
}
