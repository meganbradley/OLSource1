---
title: "CDataSource::OpenFromInitializationString"
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
  - "CDataSource.OpenFromInitializationString"
  - "OpenFromInitializationString"
  - "CDataSource::OpenFromInitializationString"
  - "ATL::CDataSource::OpenFromInitializationString"
  - "ATL.CDataSource.OpenFromInitializationString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenFromInitializationString method"
ms.assetid: 5ef1f1fd-92a9-4e1c-ad80-d3601b094b8c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource::OpenFromInitializationString
Opens a data source specified by the user-supplied initialization string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *szInitializationString*  
 [in] The initialization string.  
  
 *fPromptForInfo*  
 [in] If this argument is set to **true**, then <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will set the **DBPROP_INIT_PROMPT** property to **DBPROMPT_COMPLETEREQUIRED**, which specifies that the user be prompted only if more information is needed. This is useful for situations in which the initialization string specifies a database that requires a password, but the string does not contain the password. The user will be prompted for a password (or any other missing information) when trying to connect to the database.  
  
 The default value is **false**, which specifies that the user never be prompted (sets **DBPROP_INIT_PROMPT** to **DBPROMPT_NOPROMPT**).  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method opens a data source object using the service components in oledb32.dll; this DLL contains the implementation of Service Components features such as Resource Pooling, Automatic Transaction Enlistment, and so on.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataSource Class](../vs140/cdatasource-class.md)