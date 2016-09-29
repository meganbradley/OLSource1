---
title: "How to: Sink Windows Forms Events from Native C++ Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handling, managed/native interop"
  - "event handling, sinking .NET in C++"
  - "event handling, .NET/native interop"
  - "event handling, Windows Forms in C++"
ms.assetid: 6e30ddee-d058-4c8d-9956-2a43d86f19d5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Sink Windows Forms Events from Native C++ Classes
You can enable native C++ classes to receive callbacks from managed events raised from Windows Forms controls or other forms with the MFC macro map format. Sinking events in views and dialogs is similar to doing the same task for controls.  
  
 To do this, you need to:  
  
-   Attach an `OnClick` event handler to the control using [MAKE_DELEGATE](../vs140/make_delegate.md).  
  
-   Create a delegate map using [BEGIN_DELEGATE_MAP](../vs140/begin_delegate_map.md), [END_DELEGATE_MAP](../vs140/end_delegate_map.md), and [EVENT_DELEGATE_ENTRY](../vs140/event_delegate_entry.md).  
  
 This sample continues the work you did in [How To: Do DDX/DDV Data Binding with Windows Forms](../vs140/how-to--do-ddx-ddv-data-binding-with-windows-forms.md).  
  
 Now, you will associate your MFC control (`m_MyControl`) with a managed event handler delegate called `OnClick` for the managed <xref:System.Windows.Forms.Control.Click*> event.  
  
### To attach the OnClick event handler:  
  
1.  Add the following code to the implementation of BOOL CMFC01Dlg::OnInitDialog:  
  
    ```  
    m_MyControl.GetControl()->button1->Click += MAKE_DELEGATE( System::EventHandler, OnClick );  
    ```  
  
2.  Add the following code to the public section in the declaration of class CMFC01Dlg : public CDialog.  
  
    ```  
    // delegate map  
    BEGIN_DELEGATE_MAP( CMFC01Dlg )  
    EVENT_DELEGATE_ENTRY( OnClick, System::Object^, System::EventArgs^ )  
    END_DELEGATE_MAP()  
  
    void OnClick( System::Object^ sender, System::EventArgs^ e );  
    ```  
  
3.  Finally, add the implementation for `OnClick` to CMFC01Dlg.cpp:  
  
    ```  
    void CMFC01Dlg::OnClick(System::Object^ sender, System::EventArgs^ e)  
    {  
        AfxMessageBox(_T("Button clicked"));  
    }  
    ```  
  
## See Also  
 [MAKE_DELEGATE](../vs140/make_delegate.md)   
 [BEGIN_DELEGATE_MAP](../vs140/begin_delegate_map.md)   
 [END_DELEGATE_MAP](../vs140/end_delegate_map.md)   
 [EVENT_DELEGATE_ENTRY](../vs140/event_delegate_entry.md)