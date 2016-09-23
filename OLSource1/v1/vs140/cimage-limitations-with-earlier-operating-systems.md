---
title: "CImage Limitations with Earlier Operating Systems"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - CImage class, limitations
ms.assetid: 4bedaab8-7dd1-4c91-ab35-b75fb56765b0
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImage Limitations with Earlier Operating Systems
Many `CImage` functions work only with newer versions of Windows: Windows 95/98 or Windows NT 4.0, or Windows 2000. This article describes the version limitations of certain methods.  
  
 [CImage::PlgBlt](../vs140/cimage--plgblt.md) and [CImage::MaskBlt](../vs140/cimage--maskblt.md) work with only Windows NT 4.0 or later. They will not work on applications running on Windows 95/98 or later.  
  
 [CImage::AlphaBlend](../vs140/cimage--alphablend.md) and [CImage::TransparentBlt](../vs140/cimage--transparentblt.md) work with only Windows 2000 or later and Windows 98 or later because you must link with msimg32.lib to use these methods. (This library is available only to applications running Windows 2000 or later and Windows 98 or later.)  
  
 You can include `AlphaBlend` and `TransparentBlt` in an application that runs on Windows 95 or Windows NT 4.0 only if these methods never get called. If your application includes these methods, and it must run on earlier operating systems, you must use the linker's [/delayload](../vs140/-delayload--delay-load-import-.md) to delay the loading of msimg32.lib. As long as your application does not call one of these methods while running under Windows NT 4.0 or Windows 95, it will not attempt to load msimg32.lib. You can check the whether transparency support is available using the `CImage::IsTransparencySupported` method.  
  
## Example  
 [!code[NVC_MFCDocViewSDI#8](../vs140/codesnippet/CPP/cimage-limitations-with-earlier-operating-systems_1.cpp)]
  
  
 To compile an application that calls these methods, insert a #define _WIN32_WINNT statement before #including any system headers, indicating that the version of Windows is equal to or greater than 5.0:  
  
 [!code[NVC_MFCDocViewSDI#9](../vs140/codesnippet/CPP/cimage-limitations-with-earlier-operating-systems_2.h)]
  
  
 If your application does not need to run on an operating system older than Windows 2000 or Windows 98, you can link directly to msimg32.lib without using **/delayload**.  
  
 [CImage::Draw](../vs140/cimage--draw.md) behaves differently when used with Windows 2000 and Windows 98 than it does with Windows NT 4.0 or Windows 95.  
  
 If you compile your application with _WIN32_WINNT set to a value less than 0x0500, **Draw** will work, but it will not handle transparency automatically on systems running Windows 2000 and Windows 98 and later.  
  
 If you compile your application with _WIN32_WINNT set to 0x0500 or greater, **Draw** will handle transparency automatically on systems running Windows 2000 or Windows 98 and later. It will also work, but without transparency support, with Windows NT 4.0 and Windows 95; however, you must use **/delayload** to delay the loading of msimg32.LIB, as described above for `AlphaBlend` and `TransparentBlt`.  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)