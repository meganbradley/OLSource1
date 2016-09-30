---
title: "Clipboard: Adding Other Formats"
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
  - "formats [C++], Clipboard"
  - "Clipboard, formats"
  - "custom formats, placing on Clipboard"
  - "custom formats"
  - "registering custom Clipboard data formats"
  - "custom Clipboard data formats"
ms.assetid: aea58159-65ed-4385-aeaa-3d9d5281903b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Clipboard: Adding Other Formats
This topic explains how to expand the list of supported formats, particularly for OLE support. The topic [Clipboard: Copying and Pasting Data](../vs140/clipboard--copying-and-pasting-data.md) describes the minimum implementation necessary to support copying and pasting from the Clipboard. If this is all you implement, the only formats placed on the Clipboard are <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, **CF_EMBEDSOURCE**, **CF_OBJECTDESCRIPTOR**, and possibly <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Most applications will need more formats on the Clipboard than these three.  
  
##  \<a name="_core_registering_custom_formats">\</a> Registering Custom Formats  
 To create your own custom formats, follow the same procedure you would use when registering any custom Clipboard format: pass the name of the format to the **RegisterClipboardFormat** function and use its return value as the format ID.  
  
##  \<a name="_core_placing_formats_on_the_clipboard">\</a> Placing Formats on the Clipboard  
 To add more formats to those placed on the Clipboard, you must override the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function in the class you derived from either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (depending on whether the data to be copied is native). In this function, you should use the following procedure.  
  
#### To place formats on the Clipboard  
  
1.  Create a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
2.  Pass this data source to a function that adds your native data formats to the list of supported formats by calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
3.  Add standard formats by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for each standard format you want to support.  
  
 This technique is used in the MFC OLE sample program [HIERSVR](../vs140/visual-c---samples.md) (examine the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function of the **CServerItem** class). The only difference in this sample is that step three is not implemented because HIERSVR supports no other standard formats.  
  
### What do you want to know more about?  
  
-   [OLE data objects and data sources and uniform data transfer](../vs140/data-objects-and-data-sources--ole-.md)  
  
-   [OLE drag and drop](../vs140/drag-and-drop--ole-.md)  
  
-   [OLE](../vs140/ole-background.md)  
  
## See Also  
 [Clipboard: Using the OLE Clipboard Mechanism](../vs140/clipboard--using-the-ole-clipboard-mechanism.md)