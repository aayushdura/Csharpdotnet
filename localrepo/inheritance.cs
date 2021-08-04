using System;
namespace genes
{
    class parent
    {

    }
    class child1 : parent
    {

    }

    class child2 : child1
    {

    }

    interface ID
    {




    }

    //multiple inheritance using intrerface
    class child3 : child2, ID
    {

    }
}