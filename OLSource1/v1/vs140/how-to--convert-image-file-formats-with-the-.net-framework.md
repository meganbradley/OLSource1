---
title: "How to: Convert Image File Formats with the .NET Framework"
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
  - "GDI+ [C++], converting image file formats"
  - "graphics [C++], converting image file formats"
ms.assetid: 5d5384b0-b9b7-4262-b9ad-c4cb95f75ee4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert Image File Formats with the .NET Framework
The following code example demonstrates the <xref:System.Drawing.Image*?displayProperty=fullName> class and the <xref:System.Drawing.Imaging.ImageFormat*?displayProperty=fullName> enumeration used to convert and save image files. The following code loads an image from a .jpg file and then saves it in both .gif and .bmp file formats.  
  
> [!NOTE]
>  GDI+ is included with Windows XP, Windows Server 2003, and Windows Vista and is available as a redistributable for Windows 2000. To download the latest redistributable, see [http://go.microsoft.com/fwlink/?linkid=11232](http://go.microsoft.com/fwlink/?linkid=11232). For more information, see [GDI+](_gdiplus_GDI_start_cpp).  
  
## Example  
  
```  
#using <system.drawing.dll>  
  
using namespace System;  
using namespace System::Drawing;  
using namespace System::Drawing::Imaging;  
  
int main()  
{  
   Image^ image = Image::FromFile("SampleImage.jpg");  
   image->Save("SampleImage.png", ImageFormat::Png);  
   image->Save("SampleImage.bmp", ImageFormat::Bmp);  
  
   return 0;  
}  
```  
  
## See Also  
 <xref:System.Drawing*>   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)