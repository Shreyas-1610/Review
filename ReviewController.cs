using CommonLayer.Models;
using ManagerLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Context;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunDooNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly FunDooDbContext context;
        private readonly IReviewManager manager;
        public ReviewController(FunDooDbContext context, IReviewManager manager)
        {
            this.context = context;
            this.manager = manager;
        }

        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult createProduct(ProductModel model)
        {
            var result = manager.CreateProduct(model);
            if (result != null)
            {
                return Ok(new ResponseModel<Product> { Success = true, Message = "Product added", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = "Error while adding product" });
            }
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetProducts()
        {
            var ans = manager.GetAllProducts();
            if (ans != null)
            {
                return Ok(new ResponseModel<List<Product>> { Success = true, Message = "Product added", Data = ans });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = "Product not found" });
            }
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(int ProductId, ProductModel model)
        {
            var updateProd = manager.UpdateProduct(ProductId, model);
            if (updateProd)
            {
                return Ok(new ResponseModel<bool> { Success = true, Message = "Product updated", Data = updateProd });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = "Product not found" });
            }
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int ProductId)
        {
            var deleteProd = manager.DeleteProduct(ProductId);
            if (deleteProd)
            {
                return Ok(new ResponseModel<bool> { Success = true, Message = "Product deleted", Data = deleteProd });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = "Product not found" });
            }
        }

        //2-3
        [HttpGet("UserNotes")]
        public IActionResult GetUserNotes(int UserId)
        {
            try
            {
                var UserNotes = context.Users.Where(u => u.UserId == UserId).Select(n => new
                {
                    UserName = n.FirstName + " " + n.LastName,
                    Notes = context.Notes.Where(n => n.UserId == UserId).Select(e => new
                    {
                        e.NotesId,
                        e.Title,
                        e.Description
                    }).ToList()
                }).FirstOrDefault();

                if(UserNotes == null)
                {
                    return BadRequest(new ResponseModel<string> { Success = false, Message = "No notes or user found" });
                }
                return Ok(new { Success = true, Message = "Record found", Data = UserNotes });
            }
            catch(Exception e)
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = e.Message });
            }
        }
        //4
        [HttpGet("LabelCount")]
        public IActionResult GetLabelCount()
        {
            try
            {
                var notes = context.Notes.Select(
                    n => new
                    {
                        n.NotesId,
                        n.Title,
                        n.Description,
                        Label = context.Labels.Count(l => l.NotesId == n.NotesId)
                    }).ToList();

                return Ok(new ResponseModel<object> { Success = true, Message = "Notes with label", Data = notes });
            }
            catch( Exception e )
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = e.Message });
            }
        }
        //5
        [HttpGet("GetUsers-Notes-Collaborators")]
        public IActionResult GetUserWithNotesCollaborators()
        {
            try
            {
                var users = context.Users.Select(u => new
                {
                    UserName = u.FirstName+" "+u.LastName,
                    Notes = context.Notes.Where(n => n.UserId == u.UserId).Select(
                        n => new
                        {
                            n.NotesId,
                            n.Title,
                            n.Description,
                            Collaborators = context.Collaborator.Where(c => c.NotesId == n.NotesId)
                            .Select(c => new
                            {
                                c.CollaboratorId,
                                c.Email
                            }).ToList()
                        }).ToList()
                }).ToList();

                return Ok(new ResponseModel<object> { Success = true, Message = "Record found", Data = users });
            }
            catch(Exception e)
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = e.Message });
            }
        }
    }
}
