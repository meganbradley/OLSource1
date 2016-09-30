---
title: "Document Template Creation"
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
  - "document templates"
  - "constructors [C++], document template"
  - "document templates, creating"
  - "MFC, document templates"
  - "templates, document templates"
ms.assetid: c87f1821-7cbf-442e-9690-f126ae7fb783
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Document Template Creation
When creating a new document in response to a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or **Open** command from the **File** menu, the document template also creates a new frame window through which to view the document.  
  
 The document-template constructor specifies what types of documents, windows, and views the template will be able to create. This is determined by the arguments you pass to the document-template constructor. The following code illustrates creation of a [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md) for a sample application:  
  
 [!code[NVC_MFCDocView#7](../vs140/codesnippet/CPP/document-template-creation_1.cpp)]  
  
 The pointer to a new <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is used as an argument to [AddDocTemplate](../vs140/cwinapp--adddoctemplate.md). Arguments to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> constructor include the resource ID associated with the document type's menus and accelerators, and three uses of the [RUNTIME_CLASS](../vs140/runtime_class.md) macro. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object for the C++ class named as its argument. The three <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects passed to the document-template constructor supply the information needed to create new objects of the specified classes during the document creation process. The example shows creation of a document template that creates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects attached. The views are framed by standard MDI child frame windows.  
  
## See Also  
 [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md)   
 [Document/View Creation](../vs140/document-view-creation.md)   
 [Relationships Among MFC Objects](../vs140/relationships-among-mfc-objects.md)   
 [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md)