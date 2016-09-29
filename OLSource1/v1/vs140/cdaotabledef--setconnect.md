---
title: "CDaoTableDef::SetConnect"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoTableDef::SetConnect"
  - "CDaoTableDef.SetConnect"
  - "SetConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetConnect method"
  - "tabledefs, setting connect strings"
  - "CDaoTableDef class, setting connect strings"
ms.assetid: 02aabe5e-3c34-489e-91b8-3a31528703f3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetConnect
For a `CDaoTableDef` object that represents an attached table, the string object consists of one or two parts (a database type specifier and a path to the database).  
  
## Syntax  
  
```  
  
      void SetConnect(   
   LPCTSTR lpszConnect    
);  
```  
  
#### Parameters  
 `lpszConnect`  
 A pointer to a string expression that specifies additional parameters to pass to ODBC or installable ISAM drivers.  
  
## Remarks  
 The path as shown in the table below is the full path for the directory containing the database files and must be preceded by the identifier "DATABASE=". In some cases (as with Microsoft Jet and Microsoft Excel databases), a specific filename is included in the database path argument.  
  
> [!NOTE]
>  Do not include whitespace around the equal sign in path statements of the form "DATABASE=drive:\\\path". This will result in an exception being thrown and the connection failing.  
  
 The following table shows possible database types and their corresponding database specifiers and paths:  
  
|Database type|Specifier|Path|  
|-------------------|---------------|----------|  
|Database using the Jet database engine|"[`database`];"|"`drive`:\\\\*path*\\\\*filename*.MDB"|  
|dBASE III|"dBASE III;"|"`drive`:\\\\*path*"|  
|dBASE IV|"dBASE IV;"|"`drive`:\\\\*path*"|  
|dBASE 5|"dBASE 5.0;"|"`drive`:\\\\*path*"|  
|Paradox 3.x|"Paradox 3.x;"|"`drive`:\\\\*path*"|  
|Paradox 4.x|"Paradox 4.x;"|"`drive`:\\\\*path*"|  
|Paradox 5.x|"Paradox 5.x;"|"`drive`:\\\\*path*"|  
|Excel 3.0|"Excel 3.0;"|"`drive`:\\\\*path*\\\\*filename*.XLS"|  
|Excel 4.0|"Excel 4.0;"|"`drive`:\\\\*path*\\\\*filename*.XLS"|  
|Excel 5.0 or Excel 95|"Excel 5.0;"|"`drive`:\\\\*path*\\\\*filename*.XLS"|  
|Excel 97|"Excel 8.0;"|"`drive`:\\\\*path*\\*filename*.XLS"|  
|HTML Import|"HTML Import;"|"`drive`:\\\\*path*\\*filename*"|  
|HTML Export|"HTML Export;"|"`drive`:\\\\*path*"|  
|Text|"Text;"|"drive:\\\path"|  
|ODBC|"ODBC; DATABASE=`database`; UID=*user*;PWD=*password*; DSN=*datasourcename;* LOGINTIMEOUT=*seconds;*" (This may not be a complete connection string for all servers; it is just an example. It is very important not to have spaces between the parameters.)|None|  
|Exchange|"Exchange;<br /><br /> MAPILEVEL=*folderpath*;<br /><br /> [TABLETYPE={ 0 &#124; 1 };]<br /><br /> [PROFILE=*profile*;]<br /><br /> [PWD=*password*;]<br /><br /> [DATABASE=`database`;]"|*"drive*:\\\\*path*\\\\*filename*.MDB"|  
  
> [!NOTE]
>  Btrieve is no longer supported as of DAO 3.5.  
  
 You must use a double backslash (\\\\) in the connection strings. If you have modified the properties of an existing connection using `SetConnect`, you must subsequently call [RefreshLink](../vs140/cdaotabledef--refreshlink.md). If you are initializing the connection properties using `SetConnect`, you need not call `RefreshLink`, but should you choose to do so, first append the tabledef.  
  
 If a password is required but not provided, the ODBC driver displays a login dialog box the first time a table is accessed and again if the connection is closed and reopened.  
  
 You can set the connection string for a `CDaoTableDef` object by providing a source argument to the **Create** member function. You can check the setting to determine the type, path, user ID, password, or ODBC data source of the database. For more information, see the documentation for the specific driver.  
  
 For related information, see the topic "Connect Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::RefreshLink](../vs140/cdaotabledef--refreshlink.md)   
 [CDaoTableDef::SetAttributes](../vs140/cdaotabledef--setattributes.md)