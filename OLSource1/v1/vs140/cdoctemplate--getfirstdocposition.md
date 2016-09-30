---
title: "CDocTemplate::GetFirstDocPosition"
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
  - "CDocTemplate::GetFirstDocPosition"
  - "GetFirstDocPosition"
  - "CDocTemplate.GetFirstDocPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFirstDocPosition method"
  - "templates, getting document associated with"
  - "CDocTemplate class, attributes"
ms.assetid: f09ef3b5-8249-4cb9-9867-dab585b67c44
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::GetFirstDocPosition
Retrieves the position of the first document associated with this template.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A **POSITION** value that can be used to iterate through the list of documents associated with this document template; or **NULL** if the list is empty.  
  
## Remarks  
 Use this function to get the position of the first document in the list of documents associated with this template. Use the **POSITION** value as an argument to [CDocTemplate::GetNextDoc](../vs140/cdoctemplate--getnextdoc.md) to iterate through the list of documents associated with the template.  
  
 [CSingleDocTemplate](../vs140/csingledoctemplate-class.md) and [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md) both override this pure virtual function. Any class you derive from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> must also override this function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetNextDoc](../vs140/cdoctemplate--getnextdoc.md)   
 [CSingleDocTemplate Class](../vs140/csingledoctemplate-class.md)   
 [CMultiDocTemplate Class](../vs140/cmultidoctemplate-class.md)