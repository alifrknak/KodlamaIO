﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.DataAccess.Paging;
using Business.Dtos.Requests.Categories;
using Business.Dtos.Responses.Categories;

namespace Business.Dtos.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
        }
    }
}
