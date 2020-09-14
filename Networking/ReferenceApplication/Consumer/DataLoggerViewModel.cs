﻿//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Threading;
using UAOOI.Networking.DataRepository.DataLogger;

namespace UAOOI.Networking.ReferenceApplication.Consumer
{
  [Export(ConsumerCompositionSettings.ViewModelContract, typeof(ConsumerViewModel))]
  internal class DataLoggerViewModel : ConsumerViewModel
  {
    #region ViewModel

    public ObservableCollection<string> ConsumerLog
    {
      get => b_ConsumerLog;
      set
      {
        b_ConsumerLog = value;
        RaisePropertyChanged<ObservableCollection<string>>("ConsumerLog", b_ConsumerLog, value);
      }
    }

    #endregion ViewModel

    #region private

    /// <summary>
    /// Add the message to the <see cref="MainWindowViewModel.ConsumerLog"/>.
    /// </summary>
    /// <param name="message">The message to be added to the log <see cref="MainWindowViewModel.ConsumerLog"/>.</param>
    protected override void Trace(string message)
    {
      Application.Current.Dispatcher.Invoke(() => ConsumerLog.Insert(0, message), DispatcherPriority.Normal);
    }

    private ObservableCollection<string> b_ConsumerLog = new ObservableCollection<string>();

    #endregion private
  }
}