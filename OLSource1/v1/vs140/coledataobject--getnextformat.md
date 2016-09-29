---
title: "COleDataObject::GetNextFormat"
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
  - "COleDataObject::GetNextFormat"
  - "COleDataObject.GetNextFormat"
  - "GetNextFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "GetNextFormat method"
ms.assetid: 89f630d2-193e-41f7-9ab9-2355943d3381
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::GetNextFormat
Call this function repeatedly to obtain all the formats available for retrieving data from the item.  
  
## Syntax  
  
```  
  
      BOOL GetNextFormat(  
   LPFORMATETC lpFormatEtc   
);   
```  
  
#### Parameters  
 `lpFormatEtc`  
 Points to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure that receives the format information when the function call returns.  
  
## Return Value  
 Nonzero if another format is available; otherwise 0.  
  
## Remarks  
 After a call to [COleDataObject::BeginEnumFormats](../vs140/coledataobject--beginenumformats.md), the position of the first format supported by this data object is stored. Successive calls to `GetNextFormat` will enumerate the list of available formats in the data object. Use these functions to list the available formats.  
  
 To check for the availability of a given format, call [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
 For more information, see [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::BeginEnumFormats](../vs140/coledataobject--beginenumformats.md)   
 [COleDataObject::GetData](../vs140/coledataobject--getdata.md)   
 [COleDataObject::GetFileData](../vs140/coledataobject--getfiledata.md)   
 [COleDataObject::GetGlobalData](../vs140/coledataobject--getglobaldata.md)