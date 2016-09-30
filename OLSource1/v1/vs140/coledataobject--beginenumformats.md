---
title: "COleDataObject::BeginEnumFormats"
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
  - "COleDataObject::BeginEnumFormats"
  - "BeginEnumFormats"
  - "COleDataObject.BeginEnumFormats"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "BeginEnumFormats method"
ms.assetid: 5706ad4a-9ed1-40d0-ba56-66f610f109d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::BeginEnumFormats
Call this function to prepare for subsequent calls to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for retrieving a list of data formats from the item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 After a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the position of the first format supported by this data object is stored. Successive calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will enumerate the list of available formats in the data object.  
  
 To check on the availability of data in a given format, use [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
 For more information, see [IDataObject::EnumFormatEtc](http://msdn.microsoft.com/library/windows/desktop/ms683979) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::GetNextFormat](../vs140/coledataobject--getnextformat.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)