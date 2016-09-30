---
title: "CGdiObject::CreateStockObject"
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
  - "CGdiObject::CreateStockObject"
  - "CGdiObject.CreateStockObject"
  - "CreateStockObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateStockObject method"
  - "CGdiObject class, operations"
ms.assetid: 9687aa6a-b33b-47b5-847f-df78c717b8e7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::CreateStockObject
Retrieves a handle to one of the predefined stock Windows GDI pens, brushes, or fonts, and attaches the GDI object to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A constant specifying the type of stock object desired. See the parameter *fnObject* for [GetStockObject](http://msdn.microsoft.com/library/windows/desktop/dd144925) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of appropriate values.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 Call this function with one of the derived classes that corresponds to the Windows GDI object type, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a stock pen.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPen::CPen](../vs140/cpen--cpen.md)   
 [CBrush::CBrush](../vs140/cbrush--cbrush.md)   
 [CFont::CFont](../vs140/cfont--cfont.md)   
 [CPalette::CPalette](../vs140/cpalette--cpalette.md)