using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_app.ModelView
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SindikataModelView, Sindikata>();
            //.ForMember(d => d.CreatedOn, map => map.Ignore());
            CreateMap<DepartamentiModelView, Departamenti>();
            //.ForMember(d => d.CreatedOn, map => map.Ignore());

        }
    }
}
