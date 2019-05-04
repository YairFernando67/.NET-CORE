//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SistemaWeb2.Models.Almacen
//{
//    public class Metodos
//    {
//        // GET: api/Categorias/Listar
//        [HttpGet("[action]")]
//        public async Task<IEnumerable<CategoriaViewModel>> Listar()
//        {
//            var categoria = await _context.Categorias.ToListAsync();

//            return categoria.Select(x => new CategoriaViewModel
//            {
//                idcategoria = x.idcategoria,
//                nombre = x.nombre,
//                descripcion = x.descripcion,
//                condicion = x.condicion
//            });
//        }

//        // GET: api/Categorias/Mostrar/1
//        [HttpGet("[action]/{id}")]
//        public async Task<IActionResult> Mostrar([FromRoute]int id)
//        {
//            var categoria = await _context.Categorias.FindAsync(id);

//            if (categoria == null)
//            {
//                return NotFound();
//            }

//            return Ok(new CategoriaViewModel
//            {
//                idcategoria = categoria.idcategoria,
//                nombre = categoria.nombre,
//                descripcion = categoria.descripcion,
//                condicion = categoria.condicion
//            });
//        }

//        // PUT: api/Categorias/Actualizar
//        [HttpPut("[action]")]
//        public async Task<IActionResult> Actualizar([FromBody]ActualizarViewModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            if (model.idcategoria <= 0)
//            {
//                return BadRequest();
//            }
//            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.idcategoria == model.idcategoria);

//            if (categoria == null)
//            {
//                return NotFound();
//            }

//            categoria.nombre = model.nombre;
//            categoria.descripcion = model.descripcion;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                return BadRequest();
//            }

//            return Ok();
//        }

//        // POST: api/Categorias/Crear
//        [HttpPost("[action]")]
//        public async Task<IActionResult> Crear([FromBody]CrearViewModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            Categoria categoria = new Categoria
//            {
//                nombre = model.nombre,
//                descripcion = model.descripcion,
//                condicion = true
//            };
//            _context.Categorias.Add(categoria);
//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//            return Ok();
//        }


//        // DELETE: api/Categorias/Eliminar/5
//        [HttpDelete("[action]/{id}")]
//        public async Task<IActionResult> Eliminar([FromRoute]int id)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            var categoria = await _context.Categorias.FindAsync(id);
//            if (categoria == null)
//            {
//                return NotFound();
//            }

//            _context.Categorias.Remove(categoria);
//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//            return Ok();
//        }

//        // PUT: api/Categorias/Desactivar/1
//        [HttpPut("[action]/{id}")]
//        public async Task<IActionResult> Desactivar([FromRoute]int id)
//        {
//            if (id <= 0)
//            {
//                return BadRequest();
//            }
//            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.idcategoria == id);

//            if (categoria == null)
//            {
//                return NotFound();
//            }

//            categoria.condicion = false;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                return BadRequest();
//            }

//            return Ok();
//        }

//        // PUT: api/Categorias/Activar/1
//        [HttpPut("[action]/{id}")]
//        public async Task<IActionResult> Activar([FromRoute]int id)
//        {
//            if (id <= 0)
//            {
//                return BadRequest();
//            }
//            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.idcategoria == id);

//            if (categoria == null)
//            {
//                return NotFound();
//            }

//            categoria.condicion = true;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                return BadRequest();
//            }

//            return Ok();
//        }
//    }
//}
