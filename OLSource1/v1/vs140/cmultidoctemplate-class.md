---
title: "CMultiDocTemplate Class"
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
  - "CMultiDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDI, template"
  - "CMultiDocTemplate class"
ms.assetid: 5b8aa328-e461-41d0-b388-00594535e119
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiDocTemplate Class
Defines a document template that implements the multiple document interface (MDI).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMultiDocTemplate::CMultiDocTemplate](#cmultidoctemplate__cmultidoctemplate)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 An MDI application uses the main frame window as a workspace in which the user can open zero or more document frame windows, each of which displays a document. For a more detailed description of the MDI, see                 *Windows Interface Guidelines for Software Design*.  
  
 A document template defines the relationships among three types of classes:  
  
-   A document class, which you derive from [CDocument](../vs140/cdocument-class.md).  
  
-   A view class, which displays data from the document class listed above. You can derive this class from [CView](../vs140/cview-class.md), <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. (You can also use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directly.)  
  
-   A frame window class, which contains the view. For an MDI document template, you can derive this class from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or, if you don't need to customize the behavior of the document frame windows, you can use [CMDIChildWnd](../vs140/cmdichildwnd-class.md) directly without deriving your own class.  
  
 An MDI application can support more than one type of document, and documents of different types can be open at the same time. Your application has one document template for each document type that it supports. For example, if your MDI application supports both spreadsheets and text documents, the application has two <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects.  
  
 The application uses the document template(s) when the user creates a new document. If the application supports more than one type of document, then the framework gets the names of the supported document types from the document templates and displays them in a list in the File New dialog box. Once the user has selected a document type, the application creates a document class object, a frame window object, and a view object and attaches them to each other.  
  
 You do not need to call any member functions of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> except the constructor. The framework handles <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects internally.  
  
 For more information on <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocTemplate](../vs140/cdoctemplate-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cmultidoctemplate__cmultidoctemplate">\</a>  CMultiDocTemplate::CMultiDocTemplate  
 Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a place holder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information on the substrings, see [CDocTemplate::GetDocString](../vs140/cdoctemplate-class.md#cdoctemplate__getdocstring). This string resource is found in the application's resource file. For example:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 Note that the string begins with a '\n' character; this is because the first substring is not used for MDI applications and so is not included. You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 For more information about these resource types, see [Resource Editors](../vs140/resource-editors.md).  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object of the frame-window class. This class can be a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>-derived class, or it can be <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> itself if you want default behavior for your document frame windows.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object of the view class. This class is a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>-derived class you define to display your documents.  
  
### Remarks  
 Dynamically allocate one <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object for each document type that your application supports and pass each one to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member function of your application class.  
  
### Example  
  [!code[NVC_MFCDocView#92](../vs140/codesnippet/CPP/cmultidoctemplate-class_1.cpp)]  
  
 Here is a second example.  
  
 [!code[NVC_MFCDocView#93](../vs140/codesnippet/CPP/cmultidoctemplate-class_2.cpp)]  
  
## See Also  
 [Base Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate](../vs140/cdoctemplate-class.md)   
 [CSingleDocTemplate](../vs140/csingledoctemplate-class.md)   
 [CWinApp](../vs140/cwinapp-class.md)