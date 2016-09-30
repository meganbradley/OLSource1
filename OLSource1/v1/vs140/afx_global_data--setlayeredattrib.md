---
title: "AFX_GLOBAL_DATA::SetLayeredAttrib"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX_GLOBAL_DATA.SetLayeredAttrib"
  - "AFX_GLOBAL_DATA::SetLayeredAttrib"
  - "SetLayeredAttrib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_GLOBAL_DATA::SetLayeredAttrib"
  - "SetLayeredAttrib method"
ms.assetid: 144ad07c-d37c-4058-9794-665fdce9a403
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::SetLayeredAttrib
Provides a simple way to call the Windows [SetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633540) method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the layered window.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The transparency color key that the [Desktop Window Manager](http://msdn.microsoft.com/library/windows/desktop/aa969540) uses to compose the layered window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alpha value that is used to describe the opacity of the layered window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of flags that specify which method parameters to use. Specify LWA_COLORKEY to use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter as the transparency color. Specify LWA_ALPHA to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter to determine the opacity of the layered window.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if this method succeeds; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [SetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633540)