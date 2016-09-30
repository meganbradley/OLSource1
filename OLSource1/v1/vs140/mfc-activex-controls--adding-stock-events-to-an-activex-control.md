---
title: "MFC ActiveX Controls: Adding Stock Events to an ActiveX Control"
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
  - "EVENT__STOCK_ERROR"
  - "EVENT__STOCK_READYSTATECHANGE"
  - "ReadyStateChange"
  - "EVENT__STOCK_MOUSEMOVE"
  - "EVENT__STOCK_MOUSEUP"
  - "EVENT__STOCK_DBLCLICK"
  - "KeyPress"
  - "EVENT__STOCK_KEYDOWN"
  - "EVENT__STOCK"
  - "EVENT__STOCK_MOUSEDOWN"
  - "EVENT__STOCK_KEYPRESS"
  - "EVENT__STOCK_CLICK"
  - "EVENT__STOCK_KEYUP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC ActiveX controls, events"
  - "KeyPress event"
  - "FireDblClick event"
  - "FireMouseDown event"
  - "events [C++], stock"
  - "FireKeyPress event"
  - "EVENT_STOCK_MOUSEMOVE event"
  - "EVENT_STOCK_CLICK event"
  - "FireClick event"
  - "FireKeyUp event"
  - "FireMouseUp event"
  - "EVENT_STOCK_ERROREVENT event"
  - "EVENT_STOCK_KEYDOWN event"
  - "EVENT_STOCK_MOUSEDOWN event"
  - "EVENT_STOCK_KEYPRESS macro"
  - "EVENT_STOCK_KEYUP event"
  - "EVENT_STOCK_DBLCLICK event"
  - "FireError event"
  - "FireKeyDown event"
  - "ReadyStateChange event"
  - "EVENT_STOCK_MOUSEUP event"
  - "FireMouseMove event"
  - "EVENT_STOCK prefix"
  - "EVENT_STOCK_READYSTATECHANGE event"
  - "EVENT_STOCK_KEYPRESS event"
ms.assetid: 3eeadc67-4b3d-4444-8caa-53054073988a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Adding Stock Events to an ActiveX Control
Stock events differ from custom events in that they are automatically fired by class [COleControl](../vs140/colecontrol-class.md). <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> contains predefined member functions that fire events resulting from common actions. Some common actions implemented by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> include single- and double-clicks on the control, keyboard events, and changes in the state of the mouse buttons. Event map entries for stock events are always preceded by the **EVENT_STOCK** prefix.  
  
##  \<a name="_core_stock_events_supported_by_classwizard">\</a> Stock Events Supported by the Add Event Wizard  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class provides ten stock events, listed in the following table. You can specify the events you want in your control using the [Add Event Wizard](../vs140/add-event-wizard.md).  
  
### Stock Events  
  
|Event|Firing function|Comments|  
|-----------|---------------------|--------------|  
|Click|**void FireClick( )**|Fired when the control captures the mouse, any **BUTTONUP** (left, middle, or right) message is received, and the button is released over the control. The stock MouseDown and MouseUp events occur before this event.\<br />\<br /> Event map entry: **EVENT_STOCK_CLICK( )**|  
|DblClick|**void FireDblClick( )**|Similar to Click but fired when a **BUTTONDBLCLK** message is received.\<br />\<br /> Event map entry: **EVENT_STOCK_DBLCLICK( )**|  
|Error|**void FireError( SCODE**  *scode* **, LPCSTR**  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> **, UINT**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  **= 0 )**|Fired when an error occurs within your ActiveX control outside of the scope of a method call or property access.\<br />\<br /> Event map entry: **EVENT_STOCK_ERROREVENT( )**|  
|KeyDown|**void FireKeyDown( short**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **, short**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **)**|Fired when a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> message is received.\<br />\<br /> Event map entry: **EVENT_STOCK_KEYDOWN( )**|  
|KeyPress|**void FireKeyPress( short\***  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **)**|Fired when a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> message is received.\<br />\<br /> Event map entry: **EVENT_STOCK_KEYPRESS( )**|  
|KeyUp|**void FireKeyUp( short**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **, short**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  **)**|Fired when a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> message is received.\<br />\<br /> Event map entry: **EVENT_STOCK_KEYUP( )**|  
|MouseDown|**void FireMouseDown( short**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **, short**  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> **, float**  *x* **, float**  *y*  **)**|Fired if any **BUTTONDOWN** (left, middle, or right) is received. The mouse is captured immediately before this event is fired.\<br />\<br /> Event map entry: **EVENT_STOCK_MOUSEDOWN( )**|  
|MouseMove|**void FireMouseMove( short**  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **, short**  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **, float**  *x* **, float**  *y*  **)**|Fired when a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> message is received.\<br />\<br /> Event map entry: **EVENT_STOCK_MOUSEMOVE( )**|  
|MouseUp|**void FireMouseUp( short**  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> **, short**  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> **, float**  *x* **, float**  *y*  **)**|Fired if any **BUTTONUP** (left, middle, or right) is received. The mouse capture is released before this event is fired.\<br />\<br /> Event map entry: **EVENT_STOCK_MOUSEUP( )**|  
|ReadyStateChange|**void FireReadyStateChange( )**|Fired when a control transitions to the next ready state due to the amount of data received.\<br />\<br /> Event map entry: **EVENT_STOCK_READYSTATECHANGE( )**|  
  
##  \<a name="_core_adding_a_stock_event_using_classwizard">\</a> Adding a Stock Event Using the Add Event Wizard  
 Adding stock events requires less work than adding custom events because the firing of the actual event is handled automatically by the base class, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The following procedure adds a stock event to a control that was developed using [MFC ActiveX Control Wizard](../vs140/mfc-activex-control-wizard.md). The event, called KeyPress, fires when a key is pressed and the control is active. This procedure can also be used to add other stock events. Substitute the selected stock event name for KeyPress.  
  
#### To add the KeyPress stock event using the Add Event Wizard  
  
1.  Load your control's project.  
  
2.  In Class View, right-click your ActiveX control class to open the shortcut menu.  
  
3.  From the shortcut menu, click **Add** and then click **Add Event**.  
  
     This opens the Add Event Wizard.  
  
4.  In the **Event Name** drop-down list, select <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
5.  Click **Finish**.  
  
##  \<a name="_core_classwizard_changes_for_stock_events">\</a> Add Event Wizard Changes for Stock Events  
 Because stock events are handled by the control's base class, the Add Event Wizard does not change your class declaration in any way. It adds the event to the control's event map and makes an entry in its .IDL file. The following line is added to the control's event map, located in the control class implementation (.CPP) file:  
  
 [!code[NVC_MFC_AxUI#5](../vs140/codesnippet/CPP/mfc-activex-controls--adding-stock-events-to-an-activex-control_1.cpp)]  
  
 Adding this code fires a KeyPress event when a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> message is received and the control is active. The KeyPress event can be fired at other times by calling its firing function (for example, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) from within the control code.  
  
 The Add Event Wizard adds the following line of code to the control's .IDL file:  
  
 [!code[NVC_MFC_AxUI#6](../vs140/codesnippet/CPP/mfc-activex-controls--adding-stock-events-to-an-activex-control_2.idl)]  
  
 This line associates the KeyPress event with its standard dispatch ID and allows the container to anticipate the KeyPress event.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md)   
 [COleControl Class](../vs140/colecontrol-class.md)