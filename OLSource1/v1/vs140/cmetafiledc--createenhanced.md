---
title: "CMetaFileDC::CreateEnhanced"
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
  - "CMetaFileDC::CreateEnhanced"
  - "CreateEnhanced"
  - "CMetaFileDC.CreateEnhanced"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMetaFileDC class, initialization"
  - "CreateEnhanced method"
ms.assetid: 58eb24ee-ebd9-494d-9113-e0f91041dc30
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMetaFileDC::CreateEnhanced
Creates a device context for an enhanced-format metafile.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies a reference device for the enhanced metafile.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a null-terminated character string. Specifies the filename for the enhanced metafile to be created. If this parameter is **NULL**, the enhanced metafile is memory based and its contents lost when the object is destroyed or when the Win32 **DeleteEnhMetaFile** function is called.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) data structure or a [CRect](../vs140/crect-class.md) object that specifies the dimensions in **HIMETRIC** units (in .01-millimeter increments) of the picture to be stored in the enhanced metafile.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a zero-terminated string that specifies the name of the application that created the picture, as well as the picture's title.  
  
## Return Value  
 A handle of the device context for the enhanced metafile, if successful; otherwise **NULL**.  
  
## Remarks  
 This DC can be used to store a device-independent picture.  
  
 Windows uses the reference device identified by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter to record the resolution and units of the device on which a picture originally appeared. If the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is **NULL**, it uses the current display device for reference.  
  
 The left and top members of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> data structure pointed to by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter must be smaller than the right and bottom members, respectively. Points along the edges of the rectangle are included in the picture. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **NULL**, the graphics device interface (GDI) computes the dimensions of the smallest rectangle that can enclose the picture drawn by the application. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter should be supplied where possible.  
  
 The string pointed to by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter must contain a null character between the application name and the picture name and must terminate with two null characters —for example, "XYZ Graphics Editor\0Bald Eagle\0\0," where \0 represents the null character. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **NULL**, there is no corresponding entry in the enhanced-metafile header.  
  
 Applications use the DC created by this function to store a graphics picture in an enhanced metafile. The handle identifying this DC can be passed to any GDI function.  
  
 After an application stores a picture in an enhanced metafile, it can display the picture on any output device by calling the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. When displaying the picture, Windows uses the rectangle pointed to by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter and the resolution data from the reference device to position and scale the picture. The device context returned by this function contains the same default attributes associated with any new DC.  
  
 Applications must use the Win32 **GetWinMetaFileBits** function to convert an enhanced metafile to the older Windows metafile format.  
  
 The filename for the enhanced metafile should use the .EMF extension.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CMetaFileDC Class](../vs140/cmetafiledc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMetaFileDC::CloseEnhanced](../vs140/cmetafiledc--closeenhanced.md)   
 [CDC::PlayMetaFile](../vs140/cdc--playmetafile.md)   
 [CloseEnhMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183442)   
 [DeleteEnhMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183534)   
 [GetEnhMetaFileDescription](http://msdn.microsoft.com/library/windows/desktop/dd144882)   
 [GetEnhMetaFileHeader](http://msdn.microsoft.com/library/windows/desktop/dd144883)   
 [GetWinMetaFileBits](http://msdn.microsoft.com/library/windows/desktop/dd144952)   
 [PlayEnhMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd162800)