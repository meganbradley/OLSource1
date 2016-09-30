---
title: "Export UML diagrams to image files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b29ce2a5-0ee3-4ab7-9aa3-13ca9c6b37a2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Export UML diagrams to image files
You can export a UML document from [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to an image that is under program control. For example, you might want to do this as part of automatic document generation.  
  
 If you want to export a document to an image manually, you can copy and paste the shapes from a diagram into other programs such as Word. You can also print documents to XPS format. For more information, see [How to Save Images of Diagrams](../vs140/export-diagrams-as-images.md).  
  
## Saving an Image  
 The following code defines a shortcut menu command, also known as a context menu command, that saves an image to a file.  
  
> [!NOTE]
>  To make this code work as a menu command, you must incorporate it into a MEF component. For more information, see [How to Define a Menu Command](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
 The code first uses \<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation.IShape.GetObject*> to get the \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram*> of the underlying implementation. This type has a method \<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.CreateBitmap*>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [How to Save Images of Diagrams](../vs140/export-diagrams-as-images.md)   
 [How to Define a Menu Command](../vs140/define-a-menu-command-on-a-modeling-diagram.md)