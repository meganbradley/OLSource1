---
title: "CMFCPropertySheet::EnablePageHeader"
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
  - "CMFCPropertySheet.EnablePageHeader"
  - "CMFCPropertySheet::EnablePageHeader"
  - "EnablePageHeader"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePageHeader method"
ms.assetid: eb594dba-952d-43a5-8270-042064105c78
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::EnablePageHeader
Reserves space at the top of each page to draw a custom header.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The height of the header, in pixels.  
  
## Remarks  
 To use the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to draw a custom header, override the [CMFCPropertySheet::OnDrawPageHeader](../vs140/cmfcpropertysheet--ondrawpageheader.md) method.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertySheet::OnDrawPageHeader](../vs140/cmfcpropertysheet--ondrawpageheader.md)   
 [CMFCPropertySheet::GetHeaderHeight](../vs140/cmfcpropertysheet--getheaderheight.md)