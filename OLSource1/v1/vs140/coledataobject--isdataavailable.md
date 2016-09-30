---
title: "COleDataObject::IsDataAvailable"
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
  - "COleDataObject::IsDataAvailable"
  - "IsDataAvailable"
  - "COleDataObject.IsDataAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDataAvailable method"
  - "COleDataObject class, operations"
ms.assetid: 6b0f828f-e92f-4a57-a1ea-20731544b83c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::IsDataAvailable
Call this function to determine if a particular format is available for retrieving data from the OLE item.  
  
## Syntax  
  
```  
  
      BOOL IsDataAvailable(  
   CLIPFORMAT cfFormat,  
   LPFORMATETC lpFormatEtc = NULL   
);  
```  
  
#### Parameters  
 `cfFormat`  
 The Clipboard data format to be used in the structure pointed to by `lpFormatEtc`. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 `lpFormatEtc`  
 Points to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format desired. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by `cfFormat`. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
## Return Value  
 Nonzero if data is available in the specified format; otherwise 0.  
  
## Remarks  
 This function is useful before calling `GetData`, `GetFileData`, or `GetGlobalData`.  
  
 For more information, see [IDataObject::QueryGetData](http://msdn.microsoft.com/library/windows/desktop/ms680637) and [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CRichEditView::QueryAcceptData](../vs140/cricheditview--queryacceptdata.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::BeginEnumFormats](../vs140/coledataobject--beginenumformats.md)   
 [COleDataObject::GetData](../vs140/coledataobject--getdata.md)   
 [COleDataObject::GetFileData](../vs140/coledataobject--getfiledata.md)   
 [COleDataObject::GetGlobalData](../vs140/coledataobject--getglobaldata.md)   
 [COleDataObject::GetNextFormat](../vs140/coledataobject--getnextformat.md)