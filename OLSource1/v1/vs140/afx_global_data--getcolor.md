---
title: "AFX_GLOBAL_DATA::GetColor"
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
  - "AFX_GLOBAL_DATA.GetColor"
  - "AFX_GLOBAL_DATA::GetColor"
  - "GetColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColor method"
  - "AFX_GLOBAL_DATA::GetColor"
ms.assetid: 3623df1d-3da3-4731-9be4-f56ab9736297
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::GetColor
Retrieves the current color of the specified user interface element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value that specifies a user interface element whose color is retrieved. For a list of valid values, see the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of the [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371) method.  
  
## Return Value  
 The RGB color value of the specified user interface element. For more information, see Remarks.  
  
## Remarks  
 If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is out of range, the return value is zero. Because zero is also a valid RGB value, you cannot use this method to determine whether a system color is supported by the current operating system. Instead, use the [GetSysColorBrush](http://msdn.microsoft.com/library/windows/desktop/dd144927) method, which returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the color is not supported.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [GetSysColor Function](http://msdn.microsoft.com/library/windows/desktop/ms724371)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [GetSysColorBrush](http://msdn.microsoft.com/library/windows/desktop/dd144927)