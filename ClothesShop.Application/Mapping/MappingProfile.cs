using AutoMapper;
using ClothesShop.Domain.Entities;

/* Categories */
using ClothesShop.Application.Features.Categories.Commands.CreateCategory;
using ClothesShop.Application.Features.Categories.Commands.UpdateCategory;
using ClothesShop.Application.Features.Categories.Queries.GetAllCategories;
using ClothesShop.Application.Features.Categories.Queries.GetCategoryById;

/* Products */
using ClothesShop.Application.Features.Products.Commands.CreateProduct;
using ClothesShop.Application.Features.Products.Commands.UpdateProduct;
using ClothesShop.Application.Features.Products.Queries.GetProductById;
using ClothesShop.Application.Features.Products.Queries.GetProductsByCategory;
using ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

/* Product Variants */
using ClothesShop.Application.Features.ProductVariants.Commands.CreateProductVariant;
using ClothesShop.Application.Features.ProductVariants.Commands.UpdateProductVariant;
using ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsByProduct;

/* Videos */
using ClothesShop.Application.Features.Videos.Commands.CreateVideo;
using ClothesShop.Application.Features.Videos.Commands.UpdateVideo;
using ClothesShop.Application.Features.Videos.Queries.GetVideoById;

/* Promotions */
using ClothesShop.Application.Features.Promotions.Commands.CreatePromotion;
using ClothesShop.Application.Features.Promotions.Commands.UpdatePromotion;
using ClothesShop.Application.Features.Promotions.Queries.GetPromotionById;
using ClothesShop.Application.Features.Promotions.Queries.GetActivePromotions;
using ClothesShop.Entities;

namespace ClothesShop.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        /* ==========================
           CATEGORY
        ========================== */
        CreateMap<CreateCategoryCommand, Category>().ReverseMap();
        CreateMap<UpdateCategoryCommand, Category>().ReverseMap();

        CreateMap<Category, GetAllCategoriesVm>().ReverseMap();
        CreateMap<Category, GetCategoryByIdVm>().ReverseMap();


        /* ==========================
           PRODUCT
        ========================== */
        CreateMap<CreateProductCommand, Product>().ReverseMap();
        CreateMap<UpdateProductCommand, Product>().ReverseMap();

        CreateMap<Product, GetProductByIdVm>().ReverseMap();
        CreateMap<Product, GetProductsByCategoryVm>().ReverseMap();

        CreateMap<Product, GetProductsForFrontOfficeVm>();


        /* ==========================
           PRODUCT VARIANT
        ========================== */
        CreateMap<CreateProductVariantCommand, ProductVariant>().ReverseMap();
        CreateMap<UpdateProductVariantCommand, ProductVariant>().ReverseMap();

        CreateMap<ProductVariant, GetVariantsByProductVm>().ReverseMap();


        /* ==========================
           VIDEO
        ========================== */
        CreateMap<CreateVideoCommand, Video>().ReverseMap();
        CreateMap<UpdateVideoCommand, Video>().ReverseMap();

        CreateMap<Video, GetVideoByIdVm>().ReverseMap();


        /* ==========================
           PROMOTION
        ========================== */
        CreateMap<CreatePromotionCommand, Promotion>().ReverseMap();
        CreateMap<UpdatePromotionCommand, Promotion>().ReverseMap();

        CreateMap<Promotion, GetPromotionByIdVm>().ReverseMap();
        CreateMap<Promotion, GetActivePromotionsVm>().ReverseMap();
    }
}
