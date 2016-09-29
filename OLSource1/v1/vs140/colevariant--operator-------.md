---
title: "COleVariant::operator &lt;&lt;, &gt;&gt;"
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
  - "COleVariant.operator>>"
  - "COleVariant.operator<<"
  - "COleVariant::operator<<>>"
  - "COleVariant::operator>>"
  - "COleVariant::operator<<"
  - "COleVariant.operator<<>>"
  - "operator<<>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleVariant class, Dump/Archive"
  - "operator>>"
  - "<< operator"
  - "operator <<, variant"
  - "operator >>, variant"
  - "COleVariant class, operators"
  - "operator>>, variant"
  - ">> operator, variant"
  - "operator<<, variant"
ms.assetid: 403722b9-2eb1-4d80-b357-67d6f01211bd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::operator &lt;&lt;, &gt;&gt;
Outputs a `COleVariant` value to `CArchive` or **CdumpContext** and inputs a `COleVariant` object from `CArchive`.  
  
## Syntax  
  
```  
  
      friend CDumpContext& AFXAPI operator <<(  
   CDumpContext& dc,  
   OleVariant varSrc   
);  
friend CArchive& AFXAPI operator <<(  
   CArchive& ar,  
   COleVariant varSrc   
);  
friend CArchive& AFXAPI operator >>(  
   CArchive& ar,  
   COleVariant& varSrc   
);  
```  
  
## Remarks  
 The `COleVariant` insertion (**<<**) operator supports diagnostic dumping and storing to an archive. The extraction (**>>**) operator supports loading from an archive.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [CArchive Class](../vs140/carchive-class.md)