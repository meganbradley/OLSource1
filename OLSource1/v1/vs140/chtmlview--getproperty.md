---
title: "CHtmlView::GetProperty"
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
  - "CHtmlView.GetProperty"
  - "CHtmlView::GetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperty method"
  - "CHtmlView class, operations"
ms.assetid: 426270a3-116b-40aa-8652-6f85680460e1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetProperty
Call this member function to get the value of the property currently associated with the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the property to retrieve.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that receives the current value of the property.  
  
## Return Value  
 In the first version, nonzero if completed successfully; otherwise zero. In the second version, a [COleVariant](../vs140/colevariant-class.md) object.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::PutProperty](../vs140/chtmlview--putproperty.md)   
 [IWebBrowser2::GetProperty](https://msdn.microsoft.com/en-us/library/aa752120.aspx)