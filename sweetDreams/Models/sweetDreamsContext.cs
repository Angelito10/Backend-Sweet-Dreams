using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace sweetDreams.Models
{
    public partial class sweetDreamsContext : DbContext
    {
        public sweetDreamsContext()
        {
        }

        public sweetDreamsContext(DbContextOptions<sweetDreamsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<DetalleCompra> DetalleCompras { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<DetalleRecetum> DetalleReceta { get; set; } = null!;
        public virtual DbSet<DetalleVentum> DetalleVenta { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Entrada> Entradas { get; set; } = null!;
        public virtual DbSet<Ingrediente> Ingredientes { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Recetum> Receta { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<RolesUser> RolesUsers { get; set; } = null!;
        public virtual DbSet<Salida> Salidas { get; set; } = null!;
        public virtual DbSet<Sucursal> Sucursals { get; set; } = null!;
        public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Ventas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-R48OIII;Initial Catalog=sweetDreams;Integrated Security=True; TrustServerCertificate= True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("calle");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("colonia");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Clientes__user_i__398D8EEE");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.MetodoPagoId).HasColumnName("metodoPago_id");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("total");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .HasConstraintName("FK__Compras__metodoP__6D0D32F4");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("FK__Compras__proveed__6C190EBB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Compras__user_id__6B24EA82");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Departamento1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.ToTable("DetalleCompra");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.CompraId).HasColumnName("compra_id");

                entity.Property(e => e.IngredienteId).HasColumnName("ingrediente_id");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("iva");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("precio_unitario");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.CompraId)
                    .HasConstraintName("FK__DetalleCo__compr__6FE99F9F");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("FK__DetalleCo__ingre__70DDC3D8");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__DetalleCo__unida__71D1E811");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.ToTable("DetallePedido");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("iva");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.PedidoId).HasColumnName("pedido_id");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("precio_unitario");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__DetallePe__menu___02084FDA");

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.PedidoId)
                    .HasConstraintName("FK__DetallePe__pedid__01142BA1");
            });

            modelBuilder.Entity<DetalleRecetum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.IngredienteId).HasColumnName("ingrediente_id");

                entity.Property(e => e.Instruccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("instruccion");

                entity.Property(e => e.RecetaId).HasColumnName("receta_id");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.DetalleReceta)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("FK__DetalleRe__ingre__6477ECF3");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.DetalleReceta)
                    .HasForeignKey(d => d.RecetaId)
                    .HasConstraintName("FK__DetalleRe__recet__656C112C");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.DetalleReceta)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__DetalleRe__unida__6383C8BA");
            });

            modelBuilder.Entity<DetalleVentum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("iva");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("precio_unitario");

                entity.Property(e => e.VentaId).HasColumnName("venta_id");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__DetalleVe__menu___7A672E12");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.VentaId)
                    .HasConstraintName("FK__DetalleVe__venta__797309D9");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alergias)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alergias");

                entity.Property(e => e.ApeMaterno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ape_materno");

                entity.Property(e => e.ApePaterno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ape_paterno");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("calle");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("colonia");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.FotoEmpleado)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("foto_empleado");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NumSeguroSocial)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("num_seguro_social");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("rfc");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.DepartamentoId)
                    .HasConstraintName("FK__Empleado__depart__403A8C7D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Empleado__user_i__412EB0B6");
            });

            modelBuilder.Entity<Entrada>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.IngredienteId).HasColumnName("ingrediente_id");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("FK__Entradas__ingred__59FA5E80");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__Entradas__unidad__59063A47");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Entradas__user_i__5AEE82B9");
            });

            modelBuilder.Entity<Ingrediente>(entity =>
            {
                entity.ToTable("Ingrediente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.Ingrediente1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ingrediente");

                entity.Property(e => e.StockMinimo)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("stock_minimo");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Ingredientes)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__Ingredien__unida__4AB81AF0");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("Inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExistenciaActual)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("existencia_actual");

                entity.Property(e => e.ExistenciaInicial)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("existencia_inicial");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.IngredienteId).HasColumnName("ingrediente_id");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("FK__Inventari__ingre__5070F446");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__Inventari__unida__4F7CD00D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Inventari__user___5165187F");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Costo)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("costo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.Foto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.RecetaId).HasColumnName("receta_id");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.RecetaId)
                    .HasConstraintName("FK__Menu__receta_id__68487DD7");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.ToTable("MetodoPago");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.MetodoPago1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("metodo_pago");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.EstatusPedido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("estatus_pedido");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.MetodoPagoId).HasColumnName("metodoPago_id");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("total");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Pedidos__cliente__7D439ABD");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .HasConstraintName("FK__Pedidos__metodoP__7E37BEF6");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("Proveedor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("alias");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Calle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("calle");

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("colonia");

                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("razon_social");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rfc");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Recetum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Duracion).HasColumnName("duracion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.Receta)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("receta");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RolesUser>(entity =>
            {
                entity.ToTable("Roles_Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Salida>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_salida");

                entity.Property(e => e.IngredienteId).HasColumnName("ingrediente_id");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("unidadMedida_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.Salida)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("FK__Salidas__ingredi__5535A963");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Salida)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .HasConstraintName("FK__Salidas__unidadM__5441852A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Salida)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Salidas__user_id__5629CD9C");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.ToTable("Sucursal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("calle");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("colonia");

                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("razon_social");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<UnidadMedidum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidad");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ConfirmedAt)
                    .HasColumnType("date")
                    .HasColumnName("confirmed_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baja).HasColumnName("baja");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.MetodoPagoId).HasColumnName("metodoPago_id");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("total");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Ventas__cliente___74AE54BC");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .HasConstraintName("FK__Ventas__metodoPa__75A278F5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
