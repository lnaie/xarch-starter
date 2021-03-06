﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Definition.Interfaces
{
    public interface IPageService
    {
        void Map(Type pageType, Type viewModelType);

        Task<Page> Build(Type pageType, object parameter);

        object GetBindingContext(Type pageType);
        
    }
}
