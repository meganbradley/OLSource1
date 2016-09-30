---
title: "COlePropertyPage::GetObjectArray"
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
  - "COlePropertyPage::GetObjectArray"
  - "GetObjectArray"
  - "COlePropertyPage.GetObjectArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObjectArray method"
ms.assetid: 85f9dd20-a4fd-4246-b0e3-8e4fda0b1c9e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertyPage::GetObjectArray
Returns the array of objects being edited by the property page.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an unsigned long integer that will receive the number of objects being edited by the page.  
  
## Return Value  
 Pointer to an array of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointers, which are used to access the properties of each control on the property page. The caller must not release these interface pointers.  
  
## Remarks  
 Each property page object maintains an array of pointers to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interfaces of the objects being edited by the page. This function sets its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument to the number of elements in that array and returns a pointer to the first element of the array.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)