﻿using Application.Dto.Category;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<GetCategoryDto> GetAllCategories()
        {
            var categories = _repository.GetAll();
            return _mapper.Map<IEnumerable<GetCategoryDto>>(categories);
        }

        public GetCategoryDto GetCategoryById(Guid id)
        {
            var category = _repository.GetById(id);
            return _mapper.Map<GetCategoryDto>(category);
        }
        public Guid AddNewCategory(CreateCategoryDto newCategory)
        {
            var category = _mapper.Map<Category>(newCategory);

            _repository.Add(category);

            return category.Id;
        }

        public void DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        

        public void UpdateCategory(Guid id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
