using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MappingProfile
{
    public class EvaluationProfile:Profile
    {
        public EvaluationProfile()
        {
            CreateMap<Evaluation, EvaluationForCreate>();
            CreateMap<EvaluationForCreate, Evaluation>();
        }
    }
}
