﻿using Microsoft.EntityFrameworkCore;
using SMS.App.Views.IViews;
using SMS.Domain;
using SMS.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Presenters
{
    public class ProgramPresenter
    {
        private IProgramView _programView;
        private AppDbContext _dbContext;
        private IEnumerable<Programs> _programList;
        private BindingSource _bindingSource;

        public ProgramPresenter(IProgramView programView)
        {
            _programView = programView;
            _dbContext = new AppDbContext();
            _bindingSource = new BindingSource();

            _programView.CreateEvent += CreateEvent;
            _programView.ReadEvent += ReadEvent;
            _programView.UpdateEvent += UpdateEvent;
            _programView.DeleteEvent += DeleteEvent;
            LoadProgramList();
            _programView.GetProgramList(_bindingSource);
        }

        private void LoadProgramList(string? search = null)
        {
            _programList = _dbContext.Programs.ToList();

            if(search != null)
            {
                _programList = _programList
                    .Where(c => c.ProgramId.ToString().Contains(search) || c.ProgramName.Contains(search))
                    .ToList();
            }

            _bindingSource.DataSource = _programList;
        }

        private void DeleteEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ReadEvent(object? sender, EventArgs e)
        {
            LoadProgramList(_programView.SearchValue);
        }

        private async void CreateEvent(object? sender, EventArgs e)
        {
            var program = new Programs
            {
                ProgramName = _programView.ProgramName,
                Description = _programView.Description
            };
            await _dbContext.Programs.AddAsync(program);
            await _dbContext.SaveChangesAsync();

            _programView.SetMessage("Program Created Successfully");

            LoadProgramList();
        }
    }
}
