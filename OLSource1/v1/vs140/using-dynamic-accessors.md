---
title: "Using Dynamic Accessors"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accessors [C++], dynamic"
  - "dynamic accessors"
ms.assetid: e5d5bfa6-2b1d-49d0-8ced-914666422431
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Dynamic Accessors
Dynamic accessors allow you to access a data source when you have no knowledge of the database schema (underlying structure). The OLE DB Templates library provides several classes to help you do this.  
  
 The [DynamicConsumer](assetId:///2ccc4c61-6749-4e83-aa81-00f8009c0dc3) sample shows how to use the dynamic accessor classes to obtain column information and dynamically create accessors.  
  
## Using CDynamicAccessor  
 [CDynamicAccessor](../vs140/cdynamicaccessor-class.md) allows you to access a data source when you have no knowledge of the database schema (the database's underlying structure). <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> methods obtain column information such as column names, count, and data type. You use this column information to create an accessor dynamically at run time. The column information is stored in a buffer that is created and managed by this class. Obtain data from the buffer using the [GetValue](../vs140/cdynamicaccessor--getvalue.md) method.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Using CDynamicStringAccessor  
 [CDynamicStringAccessor](../vs140/cdynamicstringaccessor-class.md) works like [CDynamicAccessor](../vs140/cdynamicaccessor-class.md), except in one important way. While <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> requests data in the native format reported by the provider, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> requests that the provider fetch all data accessed from the data store as string data. This is especially useful for simple tasks that do not require calculation of values in the data store, such as displaying or printing the data store's contents.  
  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods to obtain column information. You use this column information to create an accessor dynamically at run time. The column information is stored in a buffer created and managed by this class. Obtain data from the buffer using [CDynamicStringAccessor::GetString](../vs140/cdynamicstringaccessor--getstring.md) or store it to the buffer using [CDynamicStringAccessor::SetString](../vs140/cdynamicstringaccessor--setstring.md).  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Using CDynamicParameterAccessor  
 [CDynamicParameterAccessor](../vs140/cdynamicparameteraccessor-class.md) is similar to [CDynamicAccessor](../vs140/cdynamicaccessor-class.md), except that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> obtains parameter information to be set by calling the [ICommandWithParameters](https://msdn.microsoft.com/en-us/library/ms712937.aspx) interface. The provider must support <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the consumer to use this class.  
  
 The parameter information is stored in a buffer created and managed by this class. Obtain parameter data from the buffer by using [CDynamicParameterAccessor::GetParam](../vs140/cdynamicparameteraccessor--getparam.md) and [CDynamicParameterAccessor::GetParamType](../vs140/cdynamicparameteraccessor--getparamtype.md).  
  
 For an example demonstrating how to use this class to execute a SQL Server stored procedure and get the output parameter values, see Knowledge Base article Q058860, "HOWTO: Execute Stored Procedure using CDynamicParameterAccessor." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)   
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicStringAccessor Class](../vs140/cdynamicstringaccessor-class.md)   
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)   
 [DynamicConsumer Sample](assetId:///2ccc4c61-6749-4e83-aa81-00f8009c0dc3)