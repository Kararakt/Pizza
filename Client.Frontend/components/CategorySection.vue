<script lang="ts" setup>
import type { ICatalogItemListView } from '../models/models';

interface Props {
  id: string;
  title: string;
  products: ICatalogItemListView[];
}

defineProps<Props>();
</script>

<template>
  <section class="category" :id="id">
    <h2 class="category__title">{{ title }}</h2>
    <div class="category__products">
      <Product
        v-for="product in products"
        :key="product.name"
        :product="product"
        @cardClick="$emit('cardClick', product)"
        @addToCart="$emit('addToCart', product)"
      />
    </div>
  </section>
</template>

<style lang="scss" scoped>
.category {
  @include container;
  @include responsive-width;

  &__title {
    @include section-title;
  }

  &__products {
    display: flex;
    flex-wrap: wrap;
    column-gap: 2.3333rem;
  }
}
</style>
