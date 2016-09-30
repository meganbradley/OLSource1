---
title: "CSnapInItemImpl::FillData"
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
  - "CSnapInItemImpl::FillData"
  - "FillData"
  - "CSnapInItemImpl.FillData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillData method"
ms.assetid: b87891cc-d749-464d-8cfb-529dbaf40a5b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::FillData
This function is called to retrieve information about the item.  
  
## Syntax  
  
```  
  
      FillData(  
   CLIPFORMAT cf,  
   LPSTREAM pStream   
);  
```  
  
#### Parameters  
 `cf`  
 [in] The format (text, rich text, or rich text with OLE items) of the Clipboard.  
  
 `pStream`  
 [in] A pointer to the stream containing the object data.  
  
## Remarks  
 To properly implement this function, copy the correct information into the stream (`pStream`), depending on the Clipboard format indicated by `cf`.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)