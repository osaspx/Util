using System;
using Microsoft.EntityFrameworkCore;
using Util.Data.EntityFrameworkCore;
using Util.Sessions;

namespace Util.Tests.UnitOfWorks {
    /// <summary>
    /// Oracle工作单元
    /// </summary>
    public class OracleUnitOfWork : OracleUnitOfWorkBase, ITestUnitOfWork {
        /// <summary>
        /// 初始化工作单元
        /// </summary>
        /// <param name="serviceProvider">服务提供器</param>
        /// <param name="options">配置项</param>
        public OracleUnitOfWork( IServiceProvider serviceProvider, DbContextOptions<OracleUnitOfWork> options ) : base( serviceProvider, options ) {
        }

        /// <summary>
        /// 设置用户会话
        /// </summary>
        public void SetSession( ISession session ) {
            Session = session;
        }
    }
}