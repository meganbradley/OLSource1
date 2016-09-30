---
title: "How to: Draw Shapes with the .NET Framework"
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
  - "GDI+, drawing shapes"
  - "drawing, shapes"
  - "shapes"
  - "shapes, drawing"
ms.assetid: ffad5ae7-6ef4-4550-8940-be3f209a101d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Draw Shapes with the .NET Framework
The following code example uses the \<xref:System.Drawing.Graphics*> class to modify the \<xref:System.Windows.Forms.Form.OnPaint*> event handler to retrieve a pointer to the \<xref:System.Drawing.Graphics*> object for the main form. This pointer is then used to set the background color of the form and draw a line and an arc using the \<xref:System.Drawing.Graphics.DrawLine*?displayProperty=fullName> and \<xref:System.Drawing.Graphics.DrawArc*> methods.  
  
> [!NOTE]
>  GDI+ is included with Windows XP and is available as a redistributable for Windows NT 4.0 SP 6, Windows 2000, Windows 98, and Windows Me. To download the latest redistributable, see [http://go.microsoft.com/fwlink/?linkid=11232](http://go.microsoft.com/fwlink/?linkid=11232). For more information, see [GDI+](_gdiplus_GDI_start_cpp).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)   
 [System::Drawing namespace](https://msdn.microsoft.com/en-us/library/system.drawing.aspx)