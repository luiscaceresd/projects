import React from "react";
import {Box, Flex, SimpleGrid, Image } from "@chakra-ui/react";

const Highlights = () => {
  return (
    <Box backgroundColor="#FFF">
      <div>
        <Flex
          margin="0 auto"
          px={12}
          color="#fff"
          justifyContent="center"
          alignItems="center"
          maxWidth="1024px"
          height={400}
        >
            <SimpleGrid className="specials" columns={3} spacing={100} color="black" id="highlights">
                <Box bg='#EDEFEE' height='300px' width="200px" borderRadius={20} padding={10}>
                    <Image src="./icons_assets/greek salad.jpg"/>
                    <span><h4>Earth Salad</h4><h4 className="salePrice">$5.99</h4></span>
                    <p> Nullam eu ex scelerisque, euismod nunc ac, tempor neque. </p>
                </Box>

                <Box bg='#EDEFEE' height='300px' width="200px" borderRadius={20} padding={10}>
                <Image src="./icons_assets/greek salad.jpg"/>
                    <span><h4>Lemon Cake</h4><h4 className="salePrice">$3.99</h4></span>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.  Nullam eu ex scelerisque, euismod nunc ac, tempor neque. </p>
                </Box>
                <Box bg='#EDEFEE' height='300px' width="200px" borderRadius={20} padding={10}>
                <Image src="./icons_assets/greek salad.jpg"/>
                    <span><h4>Bruschetta</h4><h4 className="salePrice">$3.99</h4></span>
                    <p> Nunc et turpis est. Nullam eu ex scelerisque, euismod nunc ac, tempor neque. </p>
                </Box>
            </SimpleGrid>
        </Flex>
      </div>
    </Box>
  );
};
export default Highlights;