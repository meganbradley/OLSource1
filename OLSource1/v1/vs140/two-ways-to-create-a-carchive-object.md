---
title: "Two Ways to Create a CArchive Object"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CArchive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, closing CArchive objects"
  - "CArchive objects, closing"
  - "I/O [MFC], creating CArchive objects"
  - "serialization [C++], CArchive class"
  - "CArchive objects"
  - "storage [C++], CArchive class"
  - "data storage [C++], CArchive class"
  - "CArchive class, constructor"
ms.assetid: aefa28ce-b55c-40dc-9e42-5f038030985d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Two Ways to Create a CArchive Object
There are two ways to create a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object:  
  
-   [Implicit creation of a CArchive object via the framework](#_core_implicit_creation_of_a_carchive_object_via_the_framework)  
  
-   [Explicit creation of a CArchive object](#_core_explicit_creation_of_a_carchive_object)  
  
##  \<a name="_core_implicit_creation_of_a_carchive_object_via_the_framework">\</a> Implicit Creation of a CArchive Object via the Framework  
 The most common, and easiest, way is to let the framework create a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object for your document on behalf of the Save, Save As, and Open commands on the File menu.  
  
 Here is what the framework does when the user of your application issues the Save As command from the File menu:  
  
1.  Presents the **Save As** dialog box and gets the filename from the user.  
  
2.  Opens the file named by the user as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
3.  Creates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that points to this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. In creating the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, the framework sets the mode to "store" (write, serialize), as opposed to "load" (read, deserialize).  
  
4.  Calls the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function defined in your **CDocument**-derived class, passing it a reference to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 Your document's <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function then writes data to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, as explained shortly. Upon return from your <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function, the framework destroys the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object and then the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
 Thus, if you let the framework create the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object for your document, all you have to do is implement the document's <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function that writes and reads to and from the archive. You also have to implement <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for any <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived objects that the document's <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function in turn serializes directly or indirectly.  
  
##  \<a name="_core_explicit_creation_of_a_carchive_object">\</a> Explicit Creation of a CArchive Object  
 Besides serializing a document via the framework, there are other occasions when you may need a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. For example, you might want to serialize data to and from the Clipboard, represented by a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. Or, you may want to use a user interface for saving a file that is different from the one offered by the framework. In this case, you can explicitly create a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. You do this the same way the framework does, using the following procedure.  
  
#### To explicitly create a CArchive object  
  
1.  Construct a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object or an object derived from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
2.  Pass the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object to the constructor for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, as shown in the following example:  
  
     [!code[NVC_MFCSerialization#5](../vs140/codesnippet/CPP/two-ways-to-create-a-carchive-object_1.cpp)]  
  
     The second argument to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> constructor is an enumerated value that specifies whether the archive will be used for storing or loading data to or from the file. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function of an object checks this state by calling the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function for the archive object.  
  
 When you are finished storing or loading data to or from the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object, close it. Although the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) objects will automatically close the archive (and file), it is good practice to explicitly do so since it makes recovery from errors easier. For more information about error handling, see the article [Exceptions: Catching and Deleting Exceptions](../vs140/exceptions--catching-and-deleting-exceptions.md).  
  
#### To close the CArchive object  
  
1.  The following example illustrates how to close the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object:  
  
     [!code[NVC_MFCSerialization#6](../vs140/codesnippet/CPP/two-ways-to-create-a-carchive-object_2.cpp)]  
  
## See Also  
 [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)