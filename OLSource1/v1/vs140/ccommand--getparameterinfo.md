---
title: "CCommand::GetParameterInfo"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - GetParameterInfo
  - CCommand.GetParameterInfo
  - CCommand::GetParameterInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetParameterInfo method
ms.assetid: 9cd9277f-0161-4bd8-ad24-58e5e90b92a7
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCommand::GetParameterInfo
Gets a list of the command's parameters, their names, and their types.  
  
## Syntax  
  
```  
  
      HRESULT CCommandBase::GetParameterInfo(  
   DB_UPARAMS* pParams,  
   DBPARAMINFO** ppParamInfo,  
   OLECHAR** ppNamesBuffer   
) throw ( );  
```  
  
#### Parameters  
 See [ICommandWithParameters::GetParameterInfo](https://msdn.microsoft.com/en-us/library/ms714917.aspx) in the *OLE DB Programmer's Reference*.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CCommand Class](../vs140/ccommand-class.md)