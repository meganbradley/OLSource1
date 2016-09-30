---
title: "CAxWindow2T::Create"
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
  - "ATL.CAxWindow2T<TBase>.Create"
  - "ATL::CAxWindow2T<TBase>::Create"
  - "CAxWindow2T::Create"
  - "ATL::CAxWindow2T::Create"
  - "ATL.CAxWindow2T.Create"
  - "CAxWindow2T.Create"
  - "CAxWindow2T<TBase>::Create"
  - "CAxWindow2T<TBase>.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: f101e366-755f-42ca-ad8d-b520b48e4d86
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow2T::Create
Creates a host window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls [CWindow::Create](../vs140/cwindow--create.md) with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter set to the window class that provides control hosting (**AtlAxWinLic80**).  
  
 See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a description of the parameters and return value.  
  
 **Note** If 0 is used as the value for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow2T Class](../vs140/caxwindow2t-class.md)