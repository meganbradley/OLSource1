---
title: "CRgn::SetRectRgn"
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
  - "CRgn::SetRectRgn"
  - "CRgn.SetRectRgn"
  - "SetRectRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRectRgn method"
  - "CRgn class, operations"
ms.assetid: 71849793-5c04-4207-905d-ae3ebd484900
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::SetRectRgn
Creates a rectangular region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the rectangular region.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the rectangular region.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the rectangular region.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the rectangular region.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the rectangular region. Can be either a pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Unlike [CreateRectRgn](../vs140/crgn--createrectrgn.md), however, it does not allocate any additional memory from the local Windows application heap. Instead, it uses the space allocated for the region stored in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. This means that the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object must already have been initialized with a valid Windows region before calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The points given by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specify the minimum size of the allocated space.  
  
 Use this function instead of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member function to avoid calls to the local memory manager.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreateRectRgn](../vs140/crgn--createrectrgn.md)   
 [SetRectRgn](http://msdn.microsoft.com/library/windows/desktop/dd145087)