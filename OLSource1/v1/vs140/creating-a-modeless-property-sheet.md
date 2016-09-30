---
title: "Creating a Modeless Property Sheet"
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
  - "modeless property sheets"
  - "property sheets, modeless"
  - "Create method [C++], property sheets"
ms.assetid: eafd8a92-cc67-4a69-a5fb-742c920d1ae8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a Modeless Property Sheet
Normally, the property sheets you create will be modal. When using a modal property sheet, the user must close the property sheet before using any other part of the application. This article describes methods you can use to create a modeless property sheet that allows the user to keep the property sheet open while using other parts of the application.  
  
 To display a property sheet as a modeless dialog box instead of as a modal dialog box, call [CPropertySheet::Create](../vs140/cpropertysheet--create.md) instead of [DoModal](../vs140/cpropertysheet--domodal.md). You must also implement some extra tasks to support a modeless property sheet.  
  
 One of the additional tasks is exchanging data between the property sheet and the external object it is modifying when the property sheet is open. This is generally the same task as for standard modeless dialog boxes. Part of this task is implementing a channel of communication between the modeless property sheet and the external object to which the property settings apply. This implementation is far easier if you derive a class from [CPropertySheet](../vs140/cpropertysheet-class.md) for your modeless property sheet. This article assumes you have done so.  
  
 One method for communicating between the modeless property sheet and the external object (the current selection in a view, for example) is to define a pointer from the property sheet to the external object. Define a function (called something like <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived class to change the pointer whenever the focus changes from one external object to another. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function needs to reset the settings for each property page to reflect the newly selected external object. To accomplish this, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function must be able to access the [CPropertyPage](../vs140/cpropertypage-class.md) objects belonging to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class.  
  
 The most convenient way to provide access to property pages within a property sheet is to embed the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived object. Embedding <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived object differs from the typical design for modal dialog boxes, where the owner of the property sheet creates the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects and passes them to the property sheet via [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md).  
  
 There are many user-interface alternatives for determining when the settings of the modeless property sheet should be applied to an external object. One alternative is to apply the settings of the current property page whenever the user changes any value. Another alternative is to provide an Apply button, which allows the user to accumulate changes in the property pages before committing them to the external object. For information on ways to handle the Apply button, see the article [Handling the Apply Button](../vs140/handling-the-apply-button.md).  
  
## See Also  
 [Property Sheets](../vs140/property-sheets--mfc-.md)   
 [Exchanging Data](../vs140/exchanging-data.md)   
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)