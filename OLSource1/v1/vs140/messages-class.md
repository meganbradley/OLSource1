---
title: "messages Class"
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
  - "messages"
  - "xlocmes/std::messages"
  - "std.messages"
  - "std::messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages class"
ms.assetid: c4c71f40-4f24-48ab-9f7c-daccd8d5bd83
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# messages Class
The template class describes an object that can serve as a locale facet to retrieve localized messages from a catalog of internationalized messages for a given locale.  
  
 Currently, while the messages class is implemented, there are no messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type used within a program to encode characters in a locale.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
 This facet basically opens a catalog of messages defined in the base class messages_base, retrieves the information required, and closes the catalog.  
  
### Constructors  
  
|||  
|-|-|  
|[messages](#messages__messages)|The message facet constructor function.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#messages__char_type)|A character type that is used display messages.|  
|[string_type](#messages__string_type)|A type that describes a string of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> containing characters of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[close](#messages__close)|Closes the message catalog.|  
|[do_close](#messages__do_close)|A virtual function called to lose the message catalog.|  
|[do_get](#messages__do_get)|A virtual function called to retrieve the message catalog.|  
|[do_open](#messages__do_open)|A virtual function called to open the message catalog.|  
|[get](#messages__get)|Retrieves the message catalog.|  
|[open](#messages__open)|Opens the message catalog.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="messages__char_type">\</a>  messages::char_type  
 A character type that is used display messages.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="messages__close">\</a>  messages::close  
 Closes the message catalog.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The catalog to be closed.  
  
### Remarks  
 The member function calls [do_close](#messages__do_close)(_                        *Catval*).  
  
##  \<a name="messages__do_close">\</a>  messages::do_close  
 A virtual function called to lose the message catalog.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The catalog to be closed.  
  
### Remarks  
 The protected member function closes the message catalog <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, which must have been opened by an earlier call to [do_open](#messages__do_open).  
  
 *_Catval* must be obtained from a previously opened catalog that is not closed.  
  
### Example  
  See the example for [close](#messages__close), which calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="messages__do_get">\</a>  messages::do_get  
 A virtual function called to retrieve the message catalog.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The identification value specifying the message catalog to be searched.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The first identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The second identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The string to be returned on failure.  
  
### Return Value  
 It returns a copy of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> on failure. Otherwise, it returns a copy of the specified message sequence.  
  
### Remarks  
 The protected member function tries to obtain a message sequence from the message catalog <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. It may make use of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in doing so.  
  
### Example  
  See the example for [get](#messages__get), which calls <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="messages__do_open">\</a>  messages::do_open  
 A virtual function called to open the message catalog.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The name of the catalog to be searched.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The locale being searched for in the catalog.  
  
### Return Value  
 It returns a value that compares less than zero on failure. Otherwise, the returned value can be used as the first argument on a later call to [get](#messages__get).  
  
### Remarks  
 The protected member function tries to open a message catalog whose name is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. It may make use of the locale <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in doing so  
  
 The return value should be used as the argument on a later call to [close](#messages__close).  
  
### Example  
  See the example for [open](#messages__open), which calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="messages__get">\</a>  messages::get  
 Retrieves the message catalog.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The identification value specifying the message catalog to be searched.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The first identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The second identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The string to be returned on failure.  
  
### Return Value  
 It returns a copy of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> on failure. Otherwise, it returns a copy of the specified message sequence.  
  
### Remarks  
 The member function returns [do_get](#messages__do_get)( <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>).  
  
##  \<a name="messages__messages">\</a>  messages::messages  
 The message facet constructor function.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The name of the locale.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>).  
  
##  \<a name="messages__open">\</a>  messages::open  
 Opens the message catalog.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The name of the catalog to be searched.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The locale being searched for in the catalog.  
  
### Return Value  
 It returns a value that compares less than zero on failure. Otherwise, the returned value can be used as the first argument on a later call to [get](#messages__get).  
  
### Remarks  
 The member function returns [do_open](#messages__do_open)( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>).  
  
##  \<a name="messages__string_type">\</a>  messages::string_type  
 A type that describes a string of type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the message sequences.  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [messages_base Class](../vs140/messages_base-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)