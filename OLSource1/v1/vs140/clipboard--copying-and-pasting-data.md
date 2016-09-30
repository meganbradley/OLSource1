---
title: "Clipboard: Copying and Pasting Data"
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
  - "Clipboard, copying data to"
  - "Clipboard, pasting"
ms.assetid: 580e10be-241f-4f9f-94cf-8302edc5beef
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Clipboard: Copying and Pasting Data
This topic describes the minimum work necessary to implement copying to and pasting from the Clipboard in your OLE application. It is recommended that you read the [Data Objects and Data Sources (OLE)](../vs140/data-objects-and-data-sources--ole-.md) topics before proceeding.  
  
 Before you can implement either copying or pasting, you must first provide functions to handle the Copy, Cut, and Paste options on the Edit menu.  
  
##  \<a name="_core_copying_or_cutting_data">\</a> Copying or Cutting Data  
  
#### To copy data to the Clipboard  
  
1.  Determine whether the data to be copied is native data or is an embedded or linked item.  
  
    -   If the data is embedded or linked, obtain a pointer to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object that has been selected.  
  
    -   If the data is native and the application is a server, create a new object derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> containing the selected data. Otherwise, create a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object for the data.  
  
2.  Call the selected item's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function.  
  
3.  If the user chose a Cut operation instead of a Copy operation, delete the selected data from your application.  
  
 To see an example of this sequence, see the **OnEditCut** and **OnEditCopy** functions in the MFC OLE sample programs [OCLIENT](../vs140/visual-c---samples.md) and [HIERSVR](../vs140/visual-c---samples.md). Note that these samples maintain a pointer to the currently selected data, so step 1 is already complete.  
  
##  \<a name="_core_pasting_data">\</a> Pasting Data  
 Pasting data is more complicated than copying it because you need to choose the format to use in pasting the data into your application.  
  
#### To paste data from the Clipboard  
  
1.  In your view class, implement **OnEditPaste** to handle users choosing the Paste option from the Edit menu.  
  
2.  In the **OnEditPaste** function, create a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object and call its <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function to link this object to the data on the Clipboard.  
  
3.  Call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to check whether a particular format is available.  
  
     Alternately, you can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to look for other formats until you find one most suited to your application.  
  
4.  Perform the paste of the format.  
  
 For an example of how this works, see the implementation of the **OnEditPaste** member functions in the view classes defined in the MFC OLE sample programs [OCLIENT](../vs140/visual-c---samples.md) and [HIERSVR](../vs140/visual-c---samples.md).  
  
> [!TIP]
>  The main benefit of separating the paste operation into its own function is that the same paste code can be used when data is dropped in your application during a drag-and-drop operation. As in OCLIENT and HIERSVR, your <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function can also call **DoPasteItem**, reusing the code written to implement Paste operations.  
  
 To handle the Paste Special option on the Edit menu, see the topic [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
### What do you want to know more about?  
  
-   [Adding other formats](../vs140/clipboard--adding-other-formats.md)  
  
-   [OLE data objects and data sources and uniform data transfer](../vs140/data-objects-and-data-sources--ole-.md)  
  
-   [OLE drag and drop](../vs140/drag-and-drop--ole-.md)  
  
-   [OLE](../vs140/ole-background.md)  
  
## See Also  
 [Clipboard: Using the OLE Clipboard Mechanism](../vs140/clipboard--using-the-ole-clipboard-mechanism.md)