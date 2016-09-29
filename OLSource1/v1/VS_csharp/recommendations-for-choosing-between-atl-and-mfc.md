---
title: "Recommendations for Choosing Between ATL and MFC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC, ATL support"
  - "ATL, vs. MFC"
ms.assetid: 269325bb-11a8-4330-ad2b-a14a2458679e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recommendations for Choosing Between ATL and MFC
When developing components and applications, you can choose between two approaches — ATL and MFC (the Microsoft Foundation Class Library).  
  
## Using ATL  
 ATL is a fast, easy way to both create a COM component in C++ and maintain a small footprint. Use ATL to create a control if you don't need all of the built-in functionality that MFC automatically provides.  
  
## Using MFC  
 MFC allows you to create full applications, ActiveX controls, and active documents. If you have already created a control with MFC, you may want to continue development in MFC. When creating a new control, consider using ATL if you don't need all of MFC's built-in functionality.  
  
## Using ATL in an MFC Project  
 You can add support for using ATL in an existing MFC project by running a wizard. For details, see [Adding ATL Support to Your MFC Project](../VS_csharp/adding-atl-support-to-your-mfc-project.md).  
  
## See Also  
 [Introduction to ATL](../VS_csharp/introduction-to-atl.md)