---
title: "AfxIsExtendedFrameClass"
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
  - "AfxIsExtendedFrameClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxIsExtendedFrameClass function"
ms.assetid: 9587f158-3f8f-464c-ad01-5baf73af4d4f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxIsExtendedFrameClass
Determines whether the given window is an extended frame object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an object that is derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the provided window is an extended frame object; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> derives from one of the following classes:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 This method is useful when you have to validate that a function or method parameter is an extended frame window.  
  
## Requirements  
 **Header:** afxpriv.h  
  
## See Also  
 [Macros, Global Functions, and Global Variables](../vs140/macros--global-functions--and-global-variables.md)   
 [CWnd Class](../vs140/cwnd-class.md)   
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [COleDocIPFrameWndEx Class](assetId:///7aff0da4-5d6c-4b2e-8355-ad785719319b)   
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)