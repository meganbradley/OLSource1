---
title: "String and Character Literals  (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "R"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "L constant"
  - "escape sequences"
  - "Null strings, null-terminated strings"
  - "literal strings, C++"
  - "Null strings"
  - "string literals, syntax"
  - "string literals"
  - "literal strings"
  - "strings [C++], string literals"
  - "NULL, character constant"
  - "wide characters, strings"
ms.assetid: 61de8f6f-2714-4e7b-86b6-a3f885d3b9df
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String and Character Literals  (C++)
C++ supports various string and character types, and provides ways to express literal values of each of these types. In your source code, you express the content of your character and string literals using a character set. Universal character names and escape characters allow you to express any string using only the basic source character set. A raw string literal enables you to avoid using escape characters, and can be used to express all types of string literals. You can also create std::string literals without having to perform extra construction or conversion steps.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 String literals can have no prefix, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> prefixes to denote narrow character (single-byte or multi-byte), UTF-8, wide character (UCS-2 or UTF-16), UTF-16 and UTF-32 encodings, respectively. A raw string literal can have <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> prefixes for the raw version equivalents of these encodings.  To create temporary or static std::string values, you can use string literals or raw string literals with an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> suffix. For more information, see the String literals section below. For more information on the basic source character set, universal character names, and using characters from extended codepages in your source code, see [Character Sets](../vs140/character-sets2.md).  
  
## Character literals  
 A *character literal* is composed of a constant character. It is represented by the character surrounded by single quotation marks. There are five kinds of character literals:  
  
-   Ordinary character literals of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
-   UTF-8 character literals of type <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
-   Wide-character literals of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
-   UTF-16 character literals of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
-   UTF-32 character literals of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, for example <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 The character used for a character literal may be any character, except for the reserved characters backslash ('\\'), single quotation mark ('), or new line. Reserved characters can be specified by using an escape sequence. Characters may be specified by using universal character names, as long as the type is large enough to hold the character.  
  
### Encoding  
 Character literals are encoded differently based their prefix.  
  
-   A character literal without a prefix is an ordinary character literal. The value of an ordinary character literal containing a single character, escape sequence, or universal character name that can be represented in the execution character set has a value equal to the numerical value of its encoding in the execution character set. An ordinary character literal that contains more than one character, escape sequence, or universal character name is a *multicharacter literal*. A multicharacter literal or an ordinary character literal  that can't be represented in the execution character set is conditionally-supported, has type int, and its value is implementation-defined.  
  
-   A character literal that begins with the L prefix is a wide-character literal. The value of a wide-character literal containing a single character, escape sequence, or universal character name has a value equal to the numerical value of its encoding in the execution wide-character set unless the character literal has no representation in the execution wide-character set, in which case the value is implementation-defined. The value of a wide-character literal containing multiple characters, escape sequences, or universal character names is implementation-defined.  
  
-   A character literal that begins with the u8 prefix is a UTF-8 character literal. The value of a UTF-8 character literal containing a single character, escape sequence, or universal character name has a value equal to its ISO 10646 code point value if it can be represented by a single UTF-8 code unit (corresponding to the C0 Controls and Basic Latin Unicode block). If the value can't be represented by a single UTF-8 code unit, the program is ill-formed. A UTF-8 character literal containing more than one character, escape sequence, or universal character name is ill-formed.  
  
-   A character literal that begins with the u prefix is a UTF-16 character literal. The value of a UTF-16 character literal containing a single character, escape sequence, or universal character name has a value equal to its ISO 10646 code point value if it can be represented by a single UTF-16 code unit (corresponding to the basic multi-lingual plane). If the value can't be represented by a single UTF-16 code unit, the program is ill-formed. A UTF-16 character literal containing more than one character, escape sequence, or universal character name is ill-formed.  
  
-   A character literal that begins with the U prefix is a UTF-32 character literal. The value of a UTF-32 character literal containing a single character, escape sequence, or universal character name has a value equal to its ISO 10646 code point value. A UTF-8 character literal containing more than one character, escape sequence, or universal character name is ill-formed.  
  
###  \<a name="bkmk_Escape">\</a> Escape Sequences  
 There are three kinds of escape sequences: simple, octal, and hexadecimal. Escape sequences may be any of the following:  
  
|Value|Escape sequence|Value|Escape sequence|  
|-----------|---------------------|-----------|---------------------|  
|newline|\n|backslash|\\\|  
|horizontal tab|\t|question mark|? or \\?|  
|vertical tab|\v|single quote|\\'|  
|backspace|\b|double quote|\\"|  
|carriage return|\r|the null character|\0|  
|form feed|\f|octal|\ooo|  
|alert (bell)|\a|hexadecimal|\xhhh|  
  
 The following code shows some examples of escaped characters using ordinary character literals. The same escape sequence syntax is valid for the other character literal types.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Microsoft Specific**  
  
 To create a value from an ordinary character literal (those without a prefix), the compiler converts the character  or character sequence between single quotes into 8-bit values within a 32-bit integer. Multiple characters in the literal fill corresponding bytes as needed from high-order to low-order. To create a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> value, the compiler takes the low-order byte. To create a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value, the compiler takes the low-order word. The compiler warns that the result is truncated if any bits are set above the assigned byte or word.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An octal escape sequence is a backslash followed by a sequence of up to 3 octal digits. The behavior of an octal escape sequence that appears to contain more than three digits is treated as a 3-digit octal sequence followed by the subsequent digits as characters; this can give surprising results. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Escape sequences that appear to contain non-octal characters are evaluated as an octal sequence up to the last octal character, followed by the remaining characters. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A hexadecimal escape sequence is a backslash followed by the character <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, followed by a sequence of hexadecimal digits. An escape sequence that contains no hexadecimal digits causes compiler error C2153: "hex literals must have at least one hex digit". Leading zeroes are ignored. An escape sequence that appears to have hexadecimal and non-hexadecimal characters is evaluated as a hexadecimal escape sequence up to  the last hexadecimal character, followed by the non-hexadecimal characters.   In an ordinary or u8-prefixed character literal, the highest hexadecimal value is 0xFF. In an L-prefixed or u-prefixed wide character literal, the highest hexadecimal value is 0xFFFF. In a U-prefixed wide character literal, the highest hexadecimal value is 0xFFFFFFFF.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If a wide character literal prefixed with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> contains more than one character, the value is taken from the first character. Subsequent characters are ignored, unlike the behavior of the equivalent ordinary character literal.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
 The backslash character (\\) is a line-continuation character when it is placed at the end of a line. If you want a backslash character to appear as a character literal, you must type two backslashes in a row (<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>). For more information about the line continuation character, see [Phases of Translation](../vs140/phases-of-translation.md).  
  
###  \<a name="bkmk_UCN">\</a> Universal character names  
 In character literals and native (non-raw) string literals, any character may be represented by a universal character name.  Universal character names are formed by a prefix \U followed by an eight-digit Unicode code point, or by a prefix \u followed by a four digit Unicode code point. All eight or four digits, respectively, must be present to make a well-formed universal character name.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Surrogate Pairs**  
  
 Universal character names cannot encode values in the surrogate code point range D800-DFFF. For Unicode surrogate pairs, specify the universal character name by using <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, where NNNNNNNN is the eight-digit code point for the character. The compiler generates a surrogate pair if required.  
  
 In C++03, the language only allowed a subset of characters to be represented by their universal character names, and allowed some universal character names that didn’t actually represent any valid Unicode characters. This was fixed in the C++11 standard. In C++11, both character and string literals and identifiers can use universal character names.  For more information on universal character names, see [Character Sets](../vs140/character-sets2.md). For more information about Unicode, see [Unicode](http://msdn.microsoft.com/library/dd374081\(v=vs.85\).aspx). For more information about surrogate pairs, see [Surrogate Pairs and Supplementary Characters](http://msdn.microsoft.com/library/dd374069\(v=vs.85\).aspx).  
  
## String literals  
 A string literal represents a sequence of characters that together form a null-terminated string. The characters must be enclosed between double quotation marks. There are the following kinds of string literals:  
  
### Narrow String Literals  
 A narrow string literal is a non-prefixed, double-quote delimited, null-terminated array of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>], where n is the length of the array in bytes. A narrow string literal may contain any graphic character except the double quotation mark (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>), backslash (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>), or newline character. A narrow string literal may also contain the escape sequences listed above, and universal character names that fit in a byte.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **UTF-8 encoded strings**  
  
 A UTF-8 encoded string is a u8-prefixed, double-quote delimited, null-terminated array of type  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>], where n is the length of the encoded array in bytes. A u8-prefixed string literal may contain any graphic character except the double quotation mark (<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>), backslash (<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>), or newline character. A u8-prefixed string literal may also contain the escape sequences listed above, and any universal character name.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Wide String Literals  
 A wide string literal is a null-terminated array of constant <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> that is prefixed by '<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>' and contains any graphic character except the double quotation mark ("), backslash (\\), or newline character. A wide string literal may contain the escape sequences listed above and any universal character name.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 **char16_t and char32_t (C++11)**  
  
 C++11 introduces the portable <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (16-bit Unicode) and <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> (32-bit Unicode) character types:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Raw String Literals (C++11)  
 A raw string literal is a null-terminated array—of any character type—that contains any graphic character, including the double quotation mark ("), backslash (\\), or newline character. Raw string literals are often used in regular expressions that use character classes, and in HTML strings and XML strings. For examples, see the following article: [Bjarne Stroustrup's FAQ on C++11](http://go.microsoft.com/fwlink/?LinkId=401172).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A delimiter is a user-defined sequence of up to 16 characters that immediately precedes the opening parenthesis of a raw string literal and immediately follows its closing parenthesis.  For example, in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> the delimiter sequence is <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and the string content is <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. You can use a delimiter to disambiguate raw strings that contain both double quotation marks and parentheses. This causes a compiler error:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 But a delimiter resolves it:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 You can construct a raw string literal in which there is a newline (not the escaped character) in the source:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### std::string Literals (C++14)  
 std::string literals are Standard Library implementations of user-defined literals (see below) that are represented as "xyx"s (with a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> suffix). This kind of string literal produces a temporary object of type std::string, std::wstring, std::u32string or std::u16string depending on the prefix that is specified. When no prefix is used, as above, a std::string is produced. L"xyz"s produces a std::wstring. u"xyz"s produces a [std::u16string](../vs140/u16string.md), and U"xyz"s produces a [std::u32string](../vs140/u32string.md).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The s suffix may also be used on raw string literals:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 std::string literals are defined in the namespace <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> in the \<string> header file. Because <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> are both declared as [inline namespaces](../vs140/namespaces--c---.md), <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is automatically treated as if it belonged directly in namespace <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Size of String Literals  
 For ANSI char\* strings and other single-byte encodings (not UTF-8), the size (in bytes) of a string literal is the number of characters plus 1 for the terminating null character. For all other string types, the size is not strictly related to the number of characters. UTF-8 uses up to four char elements to encode some *code units*, and char16_t or wchar_t encoded as UTF-16 may use two elements (for a total of four bytes) to encode a single *code unit*.   This example shows the size of a wide string literal in bytes:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Notice that <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> do not include the size of the terminating null character, whose size is equal to the element size of the string type: one byte on a char* string, two bytes on wchar_t\* or char16_t\* strings, and four bytes on char32_t\* strings.  
  
 The maximum length of a string literal is 65535 bytes. This limit applies to both narrow string literals and wide string literals.  
  
### Modifying String Literals  
 Because string literals (not including std:string literals) are constants, trying to modify them—for example, str[2] = 'A'—causes a compiler error.  
  
 **Microsoft Specific**  
  
 In Visual C++ you can use a string literal to initialize a pointer to non-const <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. This is allowed in C99 code, but is deprecated in C++98 and removed in C++11. An attempt to modify the string causes an access violation, as in this example:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 You can cause the compiler to emit an error when a string literal is converted to a non_const character pointer when you set the [/Zc:strictStrings](../vs140/-zc-strictstrings--disable-string-literal-type-conversion-.md) compiler option. We recommend it for standards-compliant portable code. It is also a good practice to use the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> keyword to declare string literal-initialized pointers, because it resolves to the correct (const) type. For example, this code example catches an attempt to write to a string literal at compile time:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 In some cases, identical string literals may be pooled to save space in the executable file. In string-literal pooling, the compiler causes all references to a particular string literal to point to the same location in memory, instead of having each reference point to a separate instance of the string literal. To enable string pooling, use the [/GF](../vs140/-gf--eliminate-duplicate-strings-.md) compiler option.  
  
 **End Microsoft Specific**  
  
### Concatenating adjacent string literals  
 Adjacent wide or narrow string literals are concatenated. This declaration:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 is identical to this declaration:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 and to this declaration:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Using embedded hexadecimal escape codes to specify string literals can cause unexpected results. The following example seeks to create a string literal that contains the ASCII 5 character, followed by the characters f, i, v, and e:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The actual result is a hexadecimal 5F, which is the ASCII code for an underscore, followed by the characters i, v, and e. To get the correct result, you can use one of these:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 std::string literals, because they are std::string types, can be concatenated with the + operator that is defined for [basic_string](../vs140/basic_string-class.md) types. They can also be concatenated in the same way as adjacent string literals. In both cases, the string encoding and the suffix must match:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### String literals with universal character names  
 Native (non-raw) string literals may use universal character names to represent any character, as long as the universal character name can be encoded as one or more characters in the string type.  For example, a universal character name representing an extended character cannot be encoded in a narrow string using the ANSI code page, but it can be encoded in narrow strings in some multi-byte code pages, or in UTF-8 strings, or in a wide string. In C++11, Unicode support is extended by the char16_t* and char32_t\* string types:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
## See Also  
 [Character Sets](../vs140/character-sets2.md)   
 [Numeric, Boolean and Pointer Literals](../vs140/numeric--boolean-and-pointer-literals---c---.md)   
 [User-defined Literals](../vs140/user-defined-literals---c---.md)