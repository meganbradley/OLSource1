---
title: "MFC: Using Database Classes with Documents and Views"
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
  - "documents [C++], database applications"
  - "CDaoRecordView class, using in database forms"
  - "recordsets [C++], documents and views"
  - "CRecordView class, using in database forms"
  - "DAO recordsets [C++], documents and views"
  - "views [C++], database applications"
  - "forms [C++], database applications"
  - "record views [C++], form-based applications"
  - "document/view architecture [C++], in databases"
  - "database applications [C++], forms"
  - "database classes [C++], MFC"
  - "DAO [C++], forms in database applications"
  - "ODBC recordsets [C++], documents and views"
  - "ODBC [C++], forms"
  - "CDaoRecordView class, using in database applications"
  - "DAO recordsets [C++]"
ms.assetid: 83979974-fc63-46ac-b162-e8403a572e2c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC: Using Database Classes with Documents and Views
You can use the MFC database classes — DAO or ODBC — with or without the document/view architecture. This topic emphasizes working with documents and views. It explains:  
  
-   [How to write a form-based application](#_core_writing_a_form.2d.based_application) using a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object as the main view on your document.  
  
-   [How to use recordset objects in your documents and views](#_core_using_recordsets_in_documents_and_views).  
  
-   [Other considerations](#_core_other_factors).  
  
 For alternatives, see [MFC: Using Database Classes Without Documents and Views](../vs140/mfc--using-database-classes-without-documents-and-views.md).  
  
##  \<a name="_core_writing_a_form.2d.based_application">\</a> Writing a Form-Based Application  
 Many data-access applications are based on forms. The user interface is a form containing controls in which the user examines, enters, or edits data. To make your application form based, use class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. When you run the MFC Application Wizard and select **ODBC** client type on the **Database Support** page, the project uses <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for the view class. The wizards no longer support DAO, so if you want to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you have to code it manually.  
  
 In a form-based application, each record view object stores a pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The framework's record field exchange (RFX) mechanism exchanges data between the recordset and the data source. The dialog data exchange (DDX) mechanism exchanges data between the field data members of the recordset object and the controls on the form. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> also provides default command handler functions for navigating from record to record on the form.  
  
 To create a form-based application with the application wizard, see [Creating a Forms-Based MFC Application](../vs140/creating-a-forms-based-mfc-application.md) and [Database Support, MFC Application Wizard](../vs140/database-support--mfc-application-wizard.md).  
  
 For a full discussion of forms, see [Record Views](../vs140/record-views---mfc-data-access-.md).  
  
##  \<a name="_core_using_recordsets_in_documents_and_views">\</a> Using Recordsets in Documents and Views  
 Many simple form-based applications do not need documents. If your application is more complex, you probably want to use a document as a proxy for the database, storing a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that connects to the data source. Form-based applications usually store a pointer to a recordset object in the view. Other kinds of database applications store recordsets and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object in the document. Here are some possibilities for using documents in database applications:  
  
-   If you are accessing a recordset in a local context, create a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object locally in member functions of the document or the view, as needed.  
  
     Declare a recordset object as a local variable in a function. Pass **NULL** to the constructor, which causes the framework to create and open a temporary <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object for you. As an alternative, pass a pointer to a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. Use the recordset within the function and let it be destroyed automatically when the function exits.  
  
     When you pass **NULL** to a recordset constructor, the framework uses information returned by the recordset's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function to create a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object and open it. The wizards implement <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for you.  
  
-   If you are accessing a recordset during the lifetime of your document, embed one or more <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> objects in your document.  
  
     Construct the recordset objects either when you initialize the document or as needed. You might write a function that returns a pointer to the recordset if it already exists or constructs and opens the recordset if it does not exist yet. Close, delete, and recreate the recordset as needed, or call its **Requery** member function to refresh the records.  
  
-   If you are accessing a data source during the lifetime of your document, embed a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object or store a pointer to a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object in it.  
  
     The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object manages a connection to your data source. The object is constructed automatically during document construction, and you call its **Open** member function when you initialize the document. When you construct recordset objects in document member functions, you pass a pointer to the document's <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object. This associates each recordset with its data source. The database object is usually destroyed when the document closes. The recordset objects are typically destroyed when they exit the scope of a function.  
  
##  \<a name="_core_other_factors">\</a> Other Factors  
 Form-based applications often do not have any use for the framework's document serialization mechanism, so you might want to remove, disable, or replace the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and **Open** commands on the **File** menu. See the article [Serialization: Serialization vs. Database Input/Output](../vs140/serialization--serialization-vs.-database-input-output.md).  
  
 You might also want to make use of the many user-interface possibilities that the framework can support. For example, you could use multiple <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects in a splitter window, open multiple recordsets in different multiple document interface (MDI) child windows, and so on.  
  
 You might want to implement printing of whatever is in your view, whether it is a form implemented with <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or something else. As classes derived from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> do not support printing, but you can override the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member function to allow printing. For more information, see class [CFormView](../vs140/cformview-class.md).  
  
 You might not want to use documents and views at all. In that case, see [MFC: Using Database Classes Without Documents and Views](../vs140/mfc--using-database-classes-without-documents-and-views.md).  
  
## See Also  
 [MFC Database Classes (ODBC and DAO)](../vs140/mfc-database-classes--odbc-and-dao-.md)