// 4. KEYWORDS

/*
C# contains reserved words that have special meaning for the compiler. 
These reserved words are called "keywords". Keywords cannot be used as an identifier 
(name of a variable, class, interface, etc.).

Keywords in C# are distributed under the following categories:
*/

/*
MODIFIER KEYWORDS

Modifier keywords are specific keywords that indicate who can modify types and type members. 
Modifiers allow or prevent certain parts of programs from being modified by other parts.

Modifier keywords :

abstract
async
const
event
extern
new
override
partial
readonly
sealed
static
unsafe
virtual
volatile
*/

/*
ACCESS MODIFIER KEYWORDS

Access modifiers are applied to the declaration of the class, method, properties, fields, and 
other members. They define the accessibility of the class and its members.

|Access Modifier|Usage|
|public   |The Public modifier allows any part of the program in the same assembly or another 
|         |assembly to access the type and its members.|
|private  |The Private modifier restricts other parts of the program from accessing the type 
          |and its members. Only code in the same class or struct can access it.|
|internal |The Internal modifier allows other program code in the same assembly to access the 
          |type or its members. It's the default access modifiers if no modifier is specified.|
|protected|	The Protected modifier allows codes in the same class or a class that derives 
          |from that class to access the type or its members.|
*/

/*
STATEMENT KEYWORDS

Statement keywords are related to program flow.

Statement keywords :

if
else
switch
case
do
for
foreach
in
while
break
continue
default
goto
return
yield
throw
try
catch
finally
checked
unchecked
fixed
lock
*/

/*
METHOD PARAMETER KEYWORDS

These keywords are applied to the parameters of a method.

Method parameters keywords :

params
ref
out
*/

/*
NAMESPACE KEYWORDS

These keywords are applied with namespace and related operators.

Namespace Keywords :

using
. operator
:: operator
extern alias
*/

/*
OPERATOR KEYWORDS

Operator keywords perform miscellaneous actions.

Operator keywords :

as
await
is
new
sizeof
typeof
stackalloc
checked
unchecked
*/

/*
ACCESS KEYWORDS

Access keywords are used to access the containing class or the base class 
of an object or class.

Access keywords :

base
this
*/

/*
LITERAL KEYWORDS

Literal keywords apply to the current instance or value of an object.

Literal keywords :

null
false
true
value
void
*/

/*
TYPE KEYWORDS

Type keywords are used for data types.

Type keywords :

bool
byte
char
class
decimal
double
enum
float
int
long
sbyte
short
string
struct
uint
ulong
ushort
*/

/*
CONTEXTUAL KEYWORDS

Contextual keywords are considered as keywords, only if used in specific contexts. 
They are not reserved and so can be used as names or identifiers.

Contextual keywords :

add
var
dynamic
global
set
value

Contextual keywords are not colored blue (default color for keywords in visual 
studio) when used as an identifier. For example, "var" in the below figure is 
not in blue, whereas the color of "this" is blue. So "var" is a contextual keyword.
*/

namespace ContextualKeywords
{
    public class @Class
    {
        public static int Var {get; set;}
        public int Nb {get; set;}
    }
}

/*
QUERY KEYWORDS

Query keywords are contextual keywords used in LINQ (Language INtegrated Query) queries.

Query keywords :

from
where
select
group
into
orderby
join
let
in
on
equals
by
ascending
descending
*/

/*
As mentioned above, a keyword cannot be used as an identifier (name of a variable, class, 
interface, etc.). However, they can be used with the prefix "@". For example, "class" is a 
reserved keyword, so it cannot be used as an identifier, but @class can be used as shown below.
*/

namespace QueryKeywords
{
    public class @Class
    {
        public static int MyProperty {get; set;}
    }

}

// Visit MSDN (MicroSoft Developer Network) for more information on keywords.