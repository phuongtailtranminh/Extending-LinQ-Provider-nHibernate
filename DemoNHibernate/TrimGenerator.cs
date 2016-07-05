using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Hql.Ast;
using NHibernate.Linq;
using NHibernate.Linq.Functions;
using NHibernate.Linq.Visitors;

namespace DemoNHibernate
{
    public class TrimGenerator : BaseHqlGeneratorForMethod
    {
        public TrimGenerator()
        {
            SupportedMethods = new[]
                               {
                                   ReflectionHelper.GetMethodDefinition<string>(x => x.Trim())
                               };
        }

        public override HqlTreeNode BuildHql(MethodInfo method, Expression targetObject, ReadOnlyCollection<Expression> arguments,
            HqlTreeBuilder treeBuilder, IHqlExpressionVisitor visitor)
        {
            return treeBuilder.MethodCall("ltrim", new[] { visitor.Visit(targetObject).AsExpression() });
        }
    }
}
