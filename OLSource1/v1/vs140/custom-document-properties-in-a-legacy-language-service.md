---
title: "Custom Document Properties in a Legacy Language Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "custom document properties, language services [managed package framework]"
  - "document properties, custom"
  - "language services [managed package framework], custom document properties"
ms.assetid: cc714a67-b33e-4440-9203-3c90f648bd9c
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Custom Document Properties in a Legacy Language Service
Document properties can be displayed in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Properties** window. Programming languages generally do not have properties associated with individual source files. However, XML supports document properties that affect the encoding, schema, and stylesheet.  
  
## Discussion  
 If your language needs custom document properties, you must derive a class from the \<xref:Microsoft.VisualStudio.Package.DocumentProperties*> class and implement the necessary properties on your derived class.  
  
 In addition, document properties are typically stored in the source file itself. This requires the language service to parse the property information from the source file to display in the **Properties** window and to update the source file when a change is made to the document properties in the **Properties** window.  
  
## Customizing the DocumentProperties Class  
 To support custom document properties, you must derive a class from the \<xref:Microsoft.VisualStudio.Package.DocumentProperties*> class and add as many properties as you need. You should also supply user attributes to organize them in the **Properties** window display. If a property has only a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> accessor, it is shown as read-only in the **Properties** window. If a property has both <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> accessors, the property can also be updated in the **Properties** window.  
  
### Example  
 Here is an example class derived from \<xref:Microsoft.VisualStudio.Package.DocumentProperties*>, showing two properties, Filename and Description. When a property is updated, a custom method on the \<xref:Microsoft.VisualStudio.Package.LanguageService*> class is called to write the property to the source file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Instantiating the Custom DocumentProperties class  
 To instantiate your custom document properties class, you must override the \<xref:Microsoft.VisualStudio.Package.LanguageService.CreateDocumentProperties*> method in your version of the \<xref:Microsoft.VisualStudio.Package.LanguageService*> class to return a single instance of your \<xref:Microsoft.VisualStudio.Package.DocumentProperties*> class.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Properties in the Source File  
 Since document properties are usually specific to the source file, the values are stored in the source file itself. This requires support from the language parser or scanner to define these properties. For example, the properties of an XML document are stored on the root node. The values on the root node are modified when the **Properties** window values are changed, and the root node is updated in the editor.  
  
### Example  
 This example stores the properties "Filename" and "Description" in the first two lines of the source file, embedded in a special comment header, as:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example shows the two methods needed to get and set the document properties from the first two lines of the source file as well as how the properties are updated if the user modifies the source file directly. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method in the example shown here is the same one called from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class as shown in the "Customizing the DocumentProperties class" section.  
  
 This example uses the scanner to determine the type of tokens in the first two lines. This example is for illustrative purposes only. A more typical approach to this situation is to parse the source file into what is called a parse tree where each node of the tree contains information about a particular token. The root node would contain the document properties.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Language Service Features (Managed Package Framework)](../vs140/legacy-language-service-features1.md)