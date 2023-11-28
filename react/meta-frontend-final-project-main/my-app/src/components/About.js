import React from "react";
import {Box, Flex, Grid, GridItem, Image} from "@chakra-ui/react";

const About = () => {
  return (
    <Box backgroundColor="#FBDABB" >
      <div>
        <Grid
                    h='300px'
                    templateRows='repeat(3, 1fr)'
                    templateColumns='repeat(6, 1fr)'
                    gap={4}
                    display="grid" placeItems="center"
                    >
                    <GridItem colSpan={5} bg='#FBDABB' ></GridItem>
                    <GridItem colSpan={1} bg='#FBDABB' ><Image src="my-app/icons_assets/Mario and Adrian b.jpg"/></GridItem>
                    <GridItem className="aboutText" colSpan={1} bg='#FBDABB' >"</GridItem>
                    <GridItem className="aboutText" rowSpan={1} colSpan={2} bg='#FBDABB'>Tremendous.</GridItem>
                    <GridItem className="aboutText" colSpan={1} bg='#FBDABB' >"</GridItem>
                    <GridItem colSpan={1} bg='#FBDABB' ><Image src="my-app/icons_assets/Mario and Adrian a.jpg"/></GridItem>
                    <GridItem colSpan={1} bg='#FBDABB' ></GridItem>
                    <GridItem rowSpan={1} colSpan={4} bg='#FBDABB' ></GridItem>
                    <GridItem rowSpan={1} colSpan={2} bg='#FBDABB' ></GridItem>
                </Grid>
      </div>
    </Box>
  );
};
export default About;