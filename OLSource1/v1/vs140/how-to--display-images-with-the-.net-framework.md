---
title: "How to: Display Images with the .NET Framework"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - GDI+ [C++], displaying images
  - graphics [C++], displaying images
ms.assetid: c0eddfa1-4bd6-4af5-a533-1fa84b360325
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Display Images with the .NET Framework
The following code example modifies the OnPaint event handler to retrieve a pointer to the <xref:System.Drawing.Graphics?qualifyHint=False> object for the main form. The <xref:System.Windows.Forms.Form.OnPaint?qualifyHint=False> function is intended for a Windows Forms application, most likely created with a Visual Studio application wizard.  
  
 The image is represented by the <xref:System.Drawing.Image?qualifyHint=False> class. The image data is loaded from a .jpg file using the <xref:System.Drawing.Image.FromFile?qualifyHint=True> method. Before the image is drawn to the form, the form is resized to accommodate the image. The drawing of the image is performed with the <xref:System.Drawing.Graphics.DrawImage?qualifyHint=True> method.  
  
 The <xref:System.Drawing.Graphics?qualifyHint=False> and <xref:System.Drawing.Image?qualifyHint=False> classes are both in the <xref:System.Drawing?qualifyHint=True> namespace.  
  
> [!NOTE]
>  GDI+ is included with Windows XP and is available as a redistributable for Windows NT 4.0 SP 6, Windows 2000, Windows 98, and Windows Me. To download the latest redistributable, see [http://go.microsoft.com/fwlink/?linkid=11232](http://go.microsoft.com/fwlink/?linkid=11232). For more information, see the GDI+ SDK documentation at [GDI+](_gdiplus_GDI_start_cpp).  
  
## Example  
  
```  
#using <system.drawing.dll>  
  
using namespace System;  
using namespace System::Drawing;  
  
protected:  
virtual Void Form1::OnPaint(PaintEventArgs^ pe) override  
{  
    Graphics^ g = pe->Graphics;  
    Image^ image = Image::FromFile("SampleImage.jpg");  
    Form::ClientSize = image->Size;  
    g->DrawImage( image, 0, 0, image->Size.Width, image->Size.Height );  
}  
```  
  
## See Also  
 <xref:System.Drawing?qualifyHint=True>   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)