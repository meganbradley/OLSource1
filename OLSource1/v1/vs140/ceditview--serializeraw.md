---
title: "CEditView::SerializeRaw"
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
  - "CEditView::SerializeRaw"
  - "CEditView.SerializeRaw"
  - "SerializeRaw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SerializeRaw method"
  - "text, reading from files"
  - "CEditView class, operations"
  - "files [C++], reading text"
  - "writing to files [C++]"
ms.assetid: d51f6d99-5c0f-4600-9632-946124dcc837
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::SerializeRaw
Call `SerializeRaw` to have a `CArchive` object read or write the text in the `CEditView` object to a text file.  
  
## Syntax  
  
```  
  
      void SerializeRaw(  
   CArchive& ar   
);  
```  
  
#### Parameters  
 `ar`  
 Reference to the `CArchive` object that stores the serialized text.  
  
## Remarks  
 `SerializeRaw` differs from `CEditView`'s internal implementation of `Serialize` in that it reads and writes only the text, without preceding object-description data.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive Class](../vs140/carchive-class.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)