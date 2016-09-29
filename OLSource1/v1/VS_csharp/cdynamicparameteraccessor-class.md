---
title: "CDynamicParameterAccessor Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL.CDynamicParameterAccessor"
  - "ATL::CDynamicParameterAccessor"
  - "CDynamicParameterAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicParameterAccessor class"
ms.assetid: 5f22626e-e80d-491f-8b3b-cedc50331960
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor Class
Similar to [CDynamicAccessor](../VS_csharp/cdynamicaccessor-class.md) but obtains parameter information to be set by calling the [ICommandWithParameters](https://msdn.microsoft.com/en-us/library/ms712937.aspx) interface.  
  
## Syntax  
  
```  
class CDynamicParameterAccessor : public CDynamicAccessor  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CDynamicParameterAccessor](../VS_csharp/cdynamicparameteraccessor--cdynamicparameteraccessor.md)|The constructor.|  
|[GetParam](../VS_csharp/cdynamicparameteraccessor--getparam.md)|Retrieves the parameter data from the buffer.|  
|[GetParamCount](../VS_csharp/cdynamicparameteraccessor--getparamcount.md)|Retrieves the number of parameters in the accessor.|  
|[GetParamIO](../VS_csharp/cdynamicparameteraccessor--getparamio.md)|Determines whether the specified parameter is an input or output parameter.|  
|[GetParamLength](../VS_csharp/cdynamicparameteraccessor--getparamlength.md)|Retrieves the length of the specified parameter stored in the buffer.|  
|[GetParamName](../VS_csharp/cdynamicparameteraccessor--getparamname.md)|Retrieves the name of a specified parameter.|  
|[GetParamStatus](../VS_csharp/cdynamicparameteraccessor--getparamstatus.md)|Retrieves the status of the specified parameter stored in the buffer.|  
|[GetParamString](../VS_csharp/cdynamicparameteraccessor--getparamstring.md)|Retrieves the string data of the specified parameter stored in the buffer.|  
|[GetParamType](../VS_csharp/cdynamicparameteraccessor--getparamtype.md)|Retrieves the data type of a specified parameter.|  
|[SetParam](../VS_csharp/cdynamicparameteraccessor--setparam.md)|Sets the buffer using the parameter data.|  
|[SetParamLength](../VS_csharp/cdynamicparameteraccessor--setparamlength.md)|Sets the length of the specified parameter stored in the buffer.|  
|[SetParamStatus](../VS_csharp/cdynamicparameteraccessor--setparamstatus.md)|Sets the status of the specified parameter stored in the buffer.|  
|[SetParamString](../VS_csharp/cdynamicparameteraccessor--setparamstring.md)|Sets the string data of the specified parameter stored in the buffer.|  
  
## Remarks  
 The provider must support `ICommandWithParameters` for the consumer to use this class.  
  
 The parameter information is stored in a buffer created and managed by this class. Obtain parameter data from the buffer by using [GetParam](../VS_csharp/cdynamicparameteraccessor--getparam.md) and [GetParamType](../VS_csharp/cdynamicparameteraccessor--getparamtype.md).  
  
 For an example demonstrating how to use this class to execute a SQL Server stored procedure and get the output parameter values, see Knowledge Base article Q058860, "HOWTO: Execute Stored Procedure using CDynamicParameterAccessor." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com/](http://support.microsoft.com).  
  
## Requirements  
 **Header**: atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../VS_csharp/caccessor-class.md)   
 [CDynamicAccessor Class](../VS_csharp/cdynamicaccessor-class.md)   
 [CManualAccessor Class](../VS_csharp/cmanualaccessor-class.md)