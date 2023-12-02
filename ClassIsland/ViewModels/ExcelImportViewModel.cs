﻿using System.Windows;
using ClassIsland.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using unvell.ReoGrid;

namespace ClassIsland.ViewModels;

public class ExcelImportViewModel : ObservableRecipient
{
    private int _slideIndex = 0;
    private int _descriptionMode = 0;
    private bool _isLoadingExcelFile = false;
    private bool _isFileSelected = false;
    private bool _isSelectingMode = false;
    private RangePosition _selectedRangePosition = RangePosition.Empty;
    private string _currentUpdatingPropertyName = "";
    private RangePosition _testSelectingRangePosition = RangePosition.Empty;
    private RangePosition _normalSelectionRangePosition = RangePosition.Empty;
    private ExcelSelectionTextBox? _currentSelectingElement = null;
    private RangePosition _testSelectingRangePosition2 = RangePosition.Empty;

    public int SlideIndex
    {
        get => _slideIndex;
        set
        {
            if (value == _slideIndex) return;
            _slideIndex = value;
            OnPropertyChanged();
        }
    }

    public int DescriptionMode
    {
        get => _descriptionMode;
        set
        {
            if (value == _descriptionMode) return;
            _descriptionMode = value;
            OnPropertyChanged();
        }
    }

    public bool IsLoadingExcelFile
    {
        get => _isLoadingExcelFile;
        set
        {
            if (value == _isLoadingExcelFile) return;
            _isLoadingExcelFile = value;
            OnPropertyChanged();
        }
    }

    public bool IsFileSelected
    {
        get => _isFileSelected;
        set
        {
            if (value == _isFileSelected) return;
            _isFileSelected = value;
            OnPropertyChanged();
        }
    }

    public bool IsSelectingMode
    {
        get => _isSelectingMode;
        set
        {
            if (value == _isSelectingMode) return;
            _isSelectingMode = value;
            OnPropertyChanged();
        }
    }

    public RangePosition SelectedRangePosition
    {
        get => _selectedRangePosition;
        set
        {
            if (value.Equals(_selectedRangePosition)) return;
            _selectedRangePosition = value;
            OnPropertyChanged();
        }
    }

    public string CurrentUpdatingPropertyName
    {
        get => _currentUpdatingPropertyName;
        set
        {
            if (value == _currentUpdatingPropertyName) return;
            _currentUpdatingPropertyName = value;
            OnPropertyChanged();
        }
    }

    public RangePosition TestSelectingRangePosition
    {
        get => _testSelectingRangePosition;
        set
        {
            if (value.Equals(_testSelectingRangePosition)) return;
            _testSelectingRangePosition = value;
            OnPropertyChanged();
        }
    }

    public RangePosition TestSelectingRangePosition2
    {
        get => _testSelectingRangePosition2;
        set
        {
            if (value.Equals(_testSelectingRangePosition2)) return;
            _testSelectingRangePosition2 = value;
            OnPropertyChanged();
        }
    }

    public RangePosition NormalSelectionRangePosition
    {
        get => _normalSelectionRangePosition;
        set
        {
            if (value.Equals(_normalSelectionRangePosition)) return;
            _normalSelectionRangePosition = value;
            OnPropertyChanged();
        }
    }

    public ExcelSelectionTextBox? CurrentSelectingElement
    {
        get => _currentSelectingElement;
        set
        {
            if (Equals(value, _currentSelectingElement)) return;
            _currentSelectingElement = value;
            OnPropertyChanged();
        }
    }
}