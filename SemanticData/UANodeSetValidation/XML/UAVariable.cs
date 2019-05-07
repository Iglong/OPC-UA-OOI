﻿//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

namespace UAOOI.SemanticData.UANodeSetValidation.XML
{
  public partial class UAVariable
  {
    /// <summary>
    /// Indicates whether the the inherited parent object is also equal to another object.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    ///   <c>true</c> if the current object is equal to the <paramref name="other">other</paramref>; otherwise,, <c>false</c> otherwise.</returns>
    protected override bool ParentEquals(UANode other)
    {
      UAVariable _other = other as UAVariable;
      if (_other == null)
        return false;
      return
        base.ParentEquals(_other) &&
        //TODO compare Value, Translation
        this.DataType == _other.DataType &&
        this.ValueRank == _other.ValueRank &&
        this.ArrayDimensions == _other.ArrayDimensions &&
        this.AccessLevel == _other.AccessLevel &&
        this.UserAccessLevel == _other.UserAccessLevel &&
        this.MinimumSamplingInterval == _other.MinimumSamplingInterval &&
        this.Historizing == _other.Historizing;
    }
  }
}